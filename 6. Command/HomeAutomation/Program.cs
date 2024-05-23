using HomeAutomation.Commands;
using HomeAutomation.Invokers;
using HomeAutomation.Receivers;

Console.WriteLine("Command pattern");
Console.WriteLine("---------------");

TestSimpleRemoteControl();

static void TestSimpleRemoteControl()
{
    Console.WriteLine("\n" + nameof(TestSimpleRemoteControl));

    SimpleRemoteControl remoteControl = new();
    Light light = new("Garage");
    LightOnCommand lightOn = new(light);

    remoteControl.SetCommand(lightOn);
    remoteControl.ButtonWasPressed();
}

TestRemoteControl();

static void TestRemoteControl()
{
    Console.WriteLine("\n" + nameof(TestRemoteControl));

    RemoteControl remoteControl = new();

    Light livingRoomLight = new("Living Room");
    Light kitchenLight = new("Kitchen");
    CeilingFan ceilingFan = new("Living Room");
    GarageDoor garageDoor = new("Garage");
    Stereo stereo = new("Living Room");

    LightOnCommand livingRoomLightOn = new(livingRoomLight);
    LightOffCommand livingRoomLightOff = new(livingRoomLight);
    LightOnCommand kitchenLightOn = new(kitchenLight);
    LightOffCommand kitchenLightOff = new(kitchenLight);

    CeilingFanOnCommand ceilingFanOn = new(ceilingFan);
    CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

    GarageDoorOpenCommand garageDoorOpen = new(garageDoor);
    GarageDoorCloseCommand garageDoorClose = new(garageDoor);

    StereoOnWithCDCommand stereoOnWithCD = new(stereo);
    StereoOffCommand stereoOff = new(stereo);

    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
    remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
    remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
    remoteControl.SetCommand(3, garageDoorOpen, garageDoorClose);
    remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

    Console.WriteLine(remoteControl);

    remoteControl.OnButtonWasPushed(0);
    remoteControl.OffButtonWasPushed(0);
    remoteControl.OnButtonWasPushed(1);
    remoteControl.OffButtonWasPushed(1);
    remoteControl.OnButtonWasPushed(2);
    remoteControl.OffButtonWasPushed(2);
    remoteControl.OnButtonWasPushed(3);
    remoteControl.OffButtonWasPushed(3);
    remoteControl.OnButtonWasPushed(4);
    remoteControl.OffButtonWasPushed(4);
}

TestRemoteControlWithUndo_Lights();

static void TestRemoteControlWithUndo_Lights()
{
    Console.WriteLine("\n" + nameof(TestRemoteControlWithUndo_Lights));

    RemoteControlWithUndo remoteControl = new();

    Light livingRoomLight = new("Living Room");

    LightOnCommand livingRoomLightOn = new(livingRoomLight);
    LightOffCommand livingRoomLightOff = new(livingRoomLight);

    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

    remoteControl.OnButtonWasPushed(0);
    remoteControl.OffButtonWasPushed(0);
    Console.WriteLine(remoteControl);

    remoteControl.UndoButtonWasPushed();
    remoteControl.OffButtonWasPushed(0);
    remoteControl.OnButtonWasPushed(0);
    Console.WriteLine(remoteControl);

    remoteControl.UndoButtonWasPushed();
}

TestRemoteControlWithUndo_CeilingFan();

static void TestRemoteControlWithUndo_CeilingFan()
{
    Console.WriteLine("\n" + nameof(TestRemoteControlWithUndo_CeilingFan));

    RemoteControlWithUndo remoteControl = new();
    CeilingFan ceilingFan = new("Living Room");

    CeilingFanMediumCommand ceilingFanMedium = new(ceilingFan);
    CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
    CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

    remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
    remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

    remoteControl.OnButtonWasPushed(0);
    remoteControl.OffButtonWasPushed(0);
    Console.WriteLine(remoteControl);
    remoteControl.UndoButtonWasPushed();

    remoteControl.OnButtonWasPushed(1);
    Console.WriteLine(remoteControl);
    remoteControl.UndoButtonWasPushed();
}

TestMacroCommand();

static void TestMacroCommand()
{
    Console.WriteLine("\n" + nameof(TestMacroCommand));

    RemoteControlWithUndo remoteControl = new();

    Light light = new("Living Room");

    LightOnCommand lightOn = new(light);
    LightOffCommand lightOff = new(light);

    Stereo stereo = new("Living Room");
    StereoOnWithCDCommand stereoOn = new(stereo);
    StereoOffCommand stereoOff = new(stereo);

    ICommand[] partyOn = [lightOn, stereoOn];
    ICommand[] partyOff = [lightOff, stereoOff];

    MacroCommand partyOnMacro = new(partyOn);
    MacroCommand partyOffMacro = new(partyOff);

    remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);
    Console.WriteLine(remoteControl);

    Console.WriteLine("--- Pushing Macro On---");
    remoteControl.OnButtonWasPushed(0);

    Console.WriteLine("--- Pushing Macro Off---");
    remoteControl.OffButtonWasPushed(0);
}
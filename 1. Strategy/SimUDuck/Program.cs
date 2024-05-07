using SimUDuck;
using SimUDuck.Behaviours;

Duck mallard = new MallarDuck();

mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();

model.PerformFly();
model.SetFlyBehaviour(new FlyRocketPowered());
model.PerformFly();

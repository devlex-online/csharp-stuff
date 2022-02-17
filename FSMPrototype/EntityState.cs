namespace FSMPrototype;

abstract class EntityState {
    protected Entity _entity;

    public void SetEntity(Entity entity) {
        _entity = entity;
    }

    public abstract void Handle1();
    public abstract void Handle2();

}

class EntityStateA : EntityState{
    public override void Handle1(){
        Console.WriteLine($"{_entity.EntityId}: Handling 1 from StateA");
        _entity.TransitionTo(new EntityStateB());
    }
    public override void Handle2(){

        Console.WriteLine($"{_entity.EntityId}: Handling 2 from StateA");
    }
}
class EntityStateB : EntityState{
    public override void Handle1(){
        Console.WriteLine($"{_entity.EntityId}: Handling 1 from StateB");
    }
    public override void Handle2(){

        Console.WriteLine($"{_entity.EntityId}: Handling 2 from StateB");
        _entity.TransitionTo(new EntityStateA());
    }
}
namespace FSMPrototype;

class Entity{
    private EntityState _entityState;
    public readonly Guid EntityId;

    public Entity(EntityState entityState){
        TransitionTo(entityState);
        EntityId = Guid.NewGuid();
    }

    public void TransitionTo(EntityState entityState){
        Console.WriteLine($"{EntityId}: TRansition from {_entityState?.GetType().Name} to {entityState.GetType().Name}");
        _entityState = entityState;
        _entityState.SetEntity(this);
    }

    public void DoSomething1(){
        _entityState.Handle1();    
    }


    public void DoSomething2(){
        _entityState.Handle2();    
    }
}
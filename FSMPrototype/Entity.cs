namespace FSMPrototype;

class Entity{
    private EntityState _entityState;

    public Entity(EntityState entityState){
        TransitionTo(entityState);
    }

    public TransitionTo(EntityState entityState){
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
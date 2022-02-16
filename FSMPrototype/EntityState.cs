namespace FSMPrototype;

abstract class EntityState {
    protected Entity _entity;

    public void SetEntity(Entity entity) {
        _entity = entity;
    }

    public abstract void Handle1();
    public abstract void Handle2();

}

class EntityStateA {
    override void Handle1(){
        _entity.TransitionTo(new EntityStateB());
    }
    override void Handle2(){

    }
}
class EntityStateB {
    override void Handle1(){

    }
    override void Handle2(){
        _entity.TransitionTo(new EntityStateA());
    }
}
public abstract class BaseState
{
    public abstract void OnStageEnter(BaseStateManager stateManager);

    public abstract void OnStageUpdate(BaseStateManager stateManager);

    public abstract void OnStageFixedUpdate(BaseStateManager stateManager);

    public abstract void OnStageExit(BaseStateManager stateManager);
}

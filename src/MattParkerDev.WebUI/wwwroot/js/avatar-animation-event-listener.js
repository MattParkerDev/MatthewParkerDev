
window.animationEventListerRegistered = false;
window.registerAnimationEventListener = (dotNetHelper) => {
    if (window.animationEventListerRegistered) {
        return;
    }
    const avatar = document.querySelector('.avatar-float');
    avatar.addEventListener('animationiteration', async () => {
        await dotNetHelper.invokeMethodAsync('RemoveAnimationClassIfScheduled');
    });
    window.animationEventListerRegistered = true;
}

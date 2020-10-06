
var _dotnetHelper;
function SetDotnetInstance(dotnetHelper) {
    _dotnetHelper = dotnetHelper;
}

function InvokeMethod(value) {
    _dotnetHelper.invokeMethodAsync("JsCallback", value);
}
public Program() {
  Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

bool toggle = true;

public void Main(string argument, UpdateType updateSource) {
    IMyTextSurfaceProvider testSurfaceProvinder = Me as IMyTextSurfaceProvider; // Me || GridTerminalSystem 
    Echo(testSurfaceProvinder.SurfaceCount);
    Echo(testSurfaceProvinder.UseGenericLcd);
   
    IMyTextSurface display = testSurfaceProvinder.GetSurface(0);
    IMyTextSurface keyboard = testSurfaceProvinder.GetSurface(1);
    
    if (toggle) {
        display.BackgroundColor = Color.Blue;
        keyboard.BackgroundColor = Color.Red;
    } else {
        display.BackgroundColor = Color.Red;
        keyboard.BackgroundColor = Color.Blue;
    }
    toggle = !toggle;
}

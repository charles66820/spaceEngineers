public Program() {}

public void Main(string argument, UpdateType updateSource) {
    IMyTextSurfaceProvider testSurfaceProvinder = Me as IMyTextSurfaceProvider; // Me || GridTerminalSystem 
    Echo(testSurfaceProvinder.SurfaceCount);
    Echo(testSurfaceProvinder.UseGenericLcd);
    /*
    IMyTextSurface display = testSurfaceProvinder.GetSurface(0);
    IMyTextSurface keyboard = testSurfaceProvinder.GetSurface(0);
    */
}

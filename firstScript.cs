public Program() {
    //RuntimeInfo.UpdateFrequency 
}

public void Main(string argument, UpdateType updateSource) {
    Echo("Hello, world!"); // Print "Hello, world!" in the console
    
    // Echo : Action<string> => Echo(string); Prints out text onto the currently running programmable block's detail info area.
    // Me : IMyProgrammableBlock; reference of the current running programmable block.
    // Runtime : IMyGridProgramRuntimeInfo; Gets runtime information for the running grid program.
    // Storage : string; Storage sting to store data between game sessions.
    // IGC : IMyIntergridCommunicationSystem; IGC instance
    // GridTerminalSystem : IMyGridTerminalSystem; Provides access to the grid terminal system as viewed from this programmable block.
}

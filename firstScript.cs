public Program() {
    // Runtime.UpdateFrequency = <UpdateFrequency>;
    // <UpdateFrequency> list :
    // UpdateFrequency.None // Does not run autonomously.
    // UpdateFrequency.Once, // Run once before the next tick. Flag is un-set automatically after the update
    // UpdateFrequency.Update1, // Run every game tick.
    // UpdateFrequency.Update10, // Run every 10th game tick.
    // UpdateFrequency.Update100 // Run every 100th game tick.

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

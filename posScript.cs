public Program() {
    //RuntimeInfo.UpdateFrequency
    Runtime.UpdateFrequency = UpdateFrequency.Update1;
}

public void Main(string argument, UpdateType updateSource) {
    var pos = Me.GetPosition();
    Echo(pos.ToString());
}

using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
[Serializable]
public sealed class BoltConfig
{
	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x77B560", Offset = "0x779B60", VA = "0x18077B560")]
	public BoltConfig()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x77B610", Offset = "0x779C10", VA = "0x18077B610")]
	internal BoltConfig Clone()
	{
		return null;
	}

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x10")]
	public int framesPerSecond;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x14")]
	public int packetSize;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x18")]
	public int packetMaxEventSize;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x1C")]
	public int maxEntityPriority;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	public int maxPropertyPriority;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x24")]
	public ScopeMode scopeMode;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	public BoltConfigLogTargets logTargets;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x2C")]
	public bool disableDejitterBuffer;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	public int clientSendRate;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x34")]
	public int clientDejitterDelay;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	public int clientDejitterDelayMin;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x3C")]
	public int clientDejitterDelayMax;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x40")]
	public int serverSendRate;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x44")]
	public int serverDejitterDelay;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x48")]
	public int serverDejitterDelayMin;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x4C")]
	public int serverDejitterDelayMax;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x50")]
	public int serverConnectionLimit;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x54")]
	public BoltConnectionAcceptMode serverConnectionAcceptMode;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x58")]
	public int commandDejitterDelay;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x5C")]
	public int commandQueueSize;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x60")]
	public int commandDelayAllowed;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x64")]
	public int commandRedundancy;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x68")]
	public float commandPingMultiplier;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x6C")]
	public bool useNetworkSimulation;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x70")]
	public float simulatedLoss;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x74")]
	public int simulatedPingMean;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x78")]
	public int simulatedPingJitter;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x7C")]
	public BoltRandomFunction simulatedRandomFunction;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x80")]
	public int connectionTimeout;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x84")]
	public int connectionRequestTimeout;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x88")]
	public int connectionRequestAttempts;
}

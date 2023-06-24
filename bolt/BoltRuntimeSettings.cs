using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000028")]
public class BoltRuntimeSettings : ScriptableObject
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000137 RID: 311 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000042")]
	public static BoltRuntimeSettings instance
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7886D0", Offset = "0x786CD0", VA = "0x1807886D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7889A0", Offset = "0x786FA0", VA = "0x1807889A0")]
	public BoltConfig GetConfigCopy()
	{
		return null;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x788A10", Offset = "0x787010", VA = "0x180788A10")]
	public BoltRuntimeSettings()
	{
	}

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x0")]
	private static BoltRuntimeSettings _instance;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal BoltConfig _config;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int debugClientCount;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int debugStartPort;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string debugStartMapName;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool debugPlayAsServer;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool showDebugInfo;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x32")]
	[SerializeField]
	public bool overrideTimeScale;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x33")]
	[SerializeField]
	public bool logUncaughtExceptions;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public bool clientCanInstantiateAll;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public BoltEditorStartMode debugEditorMode;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public KeyCode consoleToggleKey;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public bool consoleVisibleByDefault;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int compilationWarnLevel;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int editorSkin;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public bool scopeModeHideWarningInGui;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x4D")]
	[SerializeField]
	public bool showHelpButtons;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string masterServerGameId;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string masterServerEndPoint;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public bool masterServerAutoConnect;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x61")]
	[SerializeField]
	public bool masterServerAutoDisconnect;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x62")]
	[SerializeField]
	public bool showBoltEntityHints;
}

using System;
using FMOD.Studio;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[Serializable]
	public class ParamRef
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ParamRef()
		{
		}

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x18")]
		public float Value;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;
	}
}

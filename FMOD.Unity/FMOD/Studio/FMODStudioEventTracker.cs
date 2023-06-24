using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public static class FMODStudioEventTracker
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xB3DB40", Offset = "0xB3C140", VA = "0x180B3DB40")]
		public static void Register(EventDescription rawPtr)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xB3DCD0", Offset = "0xB3C2D0", VA = "0x180B3DCD0")]
		public static void Unregister(EventDescription rawPtr)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xB3DE40", Offset = "0xB3C440", VA = "0x180B3DE40")]
		public static void UnloadAll()
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xB3E540", Offset = "0xB3CB40", VA = "0x180B3E540")]
		private static void StopAllInstances(EventDescription eventDescription)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xB3E650", Offset = "0xB3CC50", VA = "0x180B3E650")]
		public static Dictionary<EventDescription, int> GetCounts()
		{
			return null;
		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<EventDescription, int> _counts;
	}
}

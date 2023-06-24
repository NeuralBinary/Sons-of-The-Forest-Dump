using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[DisallowMultipleComponent]
	public class InputManagerShipInputProvider : ShipInputProvider
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2710BD0", Offset = "0x270F1D0", VA = "0x182710BD0", Slot = "6")]
		public override float Steering()
		{
			return 0f;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2710C10", Offset = "0x270F210", VA = "0x182710C10", Slot = "7")]
		public override float Throttle()
		{
			return 0f;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2710C50", Offset = "0x270F250", VA = "0x182710C50", Slot = "8")]
		public override float Throttle2()
		{
			return 0f;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2710C90", Offset = "0x270F290", VA = "0x182710C90", Slot = "9")]
		public override float Throttle3()
		{
			return 0f;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2710CD0", Offset = "0x270F2D0", VA = "0x182710CD0", Slot = "10")]
		public override float Throttle4()
		{
			return 0f;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2710D10", Offset = "0x270F310", VA = "0x182710D10", Slot = "11")]
		public override float SternThruster()
		{
			return 0f;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2710D50", Offset = "0x270F350", VA = "0x182710D50", Slot = "12")]
		public override float BowThruster()
		{
			return 0f;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2710D90", Offset = "0x270F390", VA = "0x182710D90", Slot = "13")]
		public override float SubmarineDepth()
		{
			return 0f;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2710DD0", Offset = "0x270F3D0", VA = "0x182710DD0", Slot = "14")]
		public override bool EngineStartStop()
		{
			return default(bool);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2710E10", Offset = "0x270F410", VA = "0x182710E10", Slot = "15")]
		public override bool Anchor()
		{
			return default(bool);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2710E50", Offset = "0x270F450", VA = "0x182710E50", Slot = "16")]
		public override Vector2 DragObjectPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2710F30", Offset = "0x270F530", VA = "0x182710F30", Slot = "17")]
		public override bool DragObjectModifier()
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2710F70", Offset = "0x270F570", VA = "0x182710F70")]
		private static bool TryGetButton(string buttonName, KeyCode altKey, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2711080", Offset = "0x270F680", VA = "0x182711080")]
		private static bool TryGetButtonDown(string buttonName, KeyCode altKey, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2711190", Offset = "0x270F790", VA = "0x182711190")]
		private static float TryGetAxis(string axisName, bool showWarning = true)
		{
			return 0f;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2711290", Offset = "0x270F890", VA = "0x182711290")]
		private static float TryGetAxisRaw(string axisName, bool showWarning = true)
		{
			return 0f;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2711390", Offset = "0x270F990", VA = "0x182711390")]
		public InputManagerShipInputProvider()
		{
		}

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static int _warningCount;
	}
}

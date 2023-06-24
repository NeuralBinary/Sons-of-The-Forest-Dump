using System;
using Il2CppDummyDll;
using NWH.Common.Input;
using UnityEngine.UI;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class MobileShipInputProvider : ShipInputProvider
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2715010", Offset = "0x2713610", VA = "0x182715010", Slot = "6")]
		public override float Steering()
		{
			return 0f;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2715100", Offset = "0x2713700", VA = "0x182715100", Slot = "7")]
		public override float Throttle()
		{
			return 0f;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x27151F0", Offset = "0x27137F0", VA = "0x1827151F0", Slot = "8")]
		public override float Throttle2()
		{
			return 0f;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x27152E0", Offset = "0x27138E0", VA = "0x1827152E0", Slot = "9")]
		public override float Throttle3()
		{
			return 0f;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x27153D0", Offset = "0x27139D0", VA = "0x1827153D0", Slot = "10")]
		public override float Throttle4()
		{
			return 0f;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x27154C0", Offset = "0x2713AC0", VA = "0x1827154C0", Slot = "11")]
		public override float SternThruster()
		{
			return 0f;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x27155B0", Offset = "0x2713BB0", VA = "0x1827155B0", Slot = "12")]
		public override float BowThruster()
		{
			return 0f;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x27156A0", Offset = "0x2713CA0", VA = "0x1827156A0", Slot = "13")]
		public override float SubmarineDepth()
		{
			return 0f;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2715790", Offset = "0x2713D90", VA = "0x182715790", Slot = "14")]
		public override bool EngineStartStop()
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2715870", Offset = "0x2713E70", VA = "0x182715870", Slot = "15")]
		public override bool Anchor()
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2711390", Offset = "0x270F990", VA = "0x182711390")]
		public MobileShipInputProvider()
		{
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		public Slider steeringSlider;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		public Slider throttleSlider;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x30")]
		public Slider throttleSlider2;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		public Slider throttleSlider3;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x40")]
		public Slider throttleSlider4;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x48")]
		public Slider sternThrusterSlider;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x50")]
		public Slider bowThrusterSlider;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x58")]
		public Slider submarineDepthSlider;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x60")]
		public MobileInputButton engineStartStopButton;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x68")]
		public MobileInputButton anchorButton;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x70")]
		public MobileInputButton changeCameraButton;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x78")]
		public MobileInputButton changeShipButton;
	}
}

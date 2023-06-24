using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class LightningBoltPathScript : LightningBoltPathScriptBase
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA3CC40", Offset = "0xA3B240", VA = "0x180A3CC40", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA3D100", Offset = "0xA3B700", VA = "0x180A3D100")]
		public void Reset()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA3D120", Offset = "0xA3B720", VA = "0x180A3D120")]
		public LightningBoltPathScript()
		{
		}

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x200")]
		[Tooltip("How fast the lightning moves through the points or objects. 1 is normal speed, 0.01 is slower, so the lightning will move slowly between the points or objects.")]
		[Range(0.01f, 1f)]
		public float Speed;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x204")]
		[Tooltip("Repeat when the path completes?")]
		[SingleLineClamp("When each new point is moved to, this can provide a random value to make the movement to the next point appear more staggered or random. Leave as 1 and 1 to have constant speed. Use a higher maximum to create more randomness.", 1.0, 500.0)]
		public RangeOfFloats SpeedIntervalRange;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20C")]
		[Tooltip("Repeat when the path completes?")]
		public bool Repeat;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x210")]
		private float nextInterval;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x214")]
		private int nextIndex;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x218")]
		private Vector3? lastPoint;
	}
}

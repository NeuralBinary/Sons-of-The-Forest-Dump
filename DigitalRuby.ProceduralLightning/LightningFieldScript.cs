using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class LightningFieldScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA44E30", Offset = "0xA43430", VA = "0x180A44E30")]
		private Vector3 RandomPointInBounds()
		{
			return default(Vector3);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA44F80", Offset = "0xA43580", VA = "0x180A44F80", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA450A0", Offset = "0xA436A0", VA = "0x180A450A0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA452C0", Offset = "0xA438C0", VA = "0x180A452C0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA45480", Offset = "0xA43A80", VA = "0x180A45480")]
		public LightningFieldScript()
		{
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x1F0")]
		[Tooltip("The minimum length for a field segment")]
		[Header("Lightning Field Properties")]
		public float MinimumLength;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x1F4")]
		private float minimumLengthSquared;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x1F8")]
		[Tooltip("The bounds to put the field in.")]
		public Bounds FieldBounds;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x210")]
		[Tooltip("Optional light for the lightning field to emit")]
		public Light Light;
	}
}

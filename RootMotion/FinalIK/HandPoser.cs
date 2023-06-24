using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class HandPoser : Poser
	{
		// Token: 0x06000548 RID: 1352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2982DF0", Offset = "0x29813F0", VA = "0x182982DF0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2983040", Offset = "0x2981640", VA = "0x182983040", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x29830F0", Offset = "0x29816F0", VA = "0x1829830F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2983290", Offset = "0x2981890", VA = "0x182983290", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2983A00", Offset = "0x2982000", VA = "0x182983A00")]
		protected void StoreDefaultState()
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x29828C0", Offset = "0x2980EC0", VA = "0x1829828C0")]
		public HandPoser()
		{
		}

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x58")]
		protected Transform[] children;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x60")]
		private Transform _poseRoot;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x68")]
		private Transform[] poseChildren;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x70")]
		private Vector3[] defaultLocalPositions;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion[] defaultLocalRotations;
	}
}

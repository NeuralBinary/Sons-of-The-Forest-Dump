using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public class GenericPoser : Poser
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2981DC0", Offset = "0x29803C0", VA = "0x182981DC0", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x29823C0", Offset = "0x29809C0", VA = "0x1829823C0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x29823D0", Offset = "0x29809D0", VA = "0x1829823D0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2982530", Offset = "0x2980B30", VA = "0x182982530", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2982690", Offset = "0x2980C90", VA = "0x182982690")]
		private void StoreDefaultState()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2982800", Offset = "0x2980E00", VA = "0x182982800")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x29828C0", Offset = "0x2980EC0", VA = "0x1829828C0")]
		public GenericPoser()
		{
		}

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x58")]
		public GenericPoser.Map[] maps;

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x2000096")]
		[Serializable]
		public class Map
		{
			// Token: 0x06000544 RID: 1348 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2982910", Offset = "0x2980F10", VA = "0x182982910")]
			public Map(Transform bone, Transform target)
			{
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x29270E0", Offset = "0x29256E0", VA = "0x1829270E0")]
			public void StoreDefaultState()
			{
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x29829D0", Offset = "0x2980FD0", VA = "0x1829829D0")]
			public void FixTransform()
			{
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x2982AB0", Offset = "0x29810B0", VA = "0x182982AB0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[FieldOffset(Offset = "0x18")]
			public Transform target;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			[FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;
		}
	}
}

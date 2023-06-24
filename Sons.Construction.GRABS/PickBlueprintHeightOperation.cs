using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class PickBlueprintHeightOperation : Operation
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2DA1570", Offset = "0x2D9FB70", VA = "0x182DA1570")]
		public void Init(IGrabsControllerInput input, InteractionPoint ip, BlueprintFace face, Transform aimTransform, float rotationSpeed)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2DA17D0", Offset = "0x2D9FDD0", VA = "0x182DA17D0", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2DA2000", Offset = "0x2DA0600", VA = "0x182DA2000")]
		private void RotateBlueprint(Vector3 pivot, float rotationSpeed)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2DA2170", Offset = "0x2DA0770", VA = "0x182DA2170", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2DA22B0", Offset = "0x2DA08B0", VA = "0x182DA22B0")]
		public PickBlueprintHeightOperation()
		{
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		private readonly float _castHeightAboveAim;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x2C")]
		private float _rotationSpeed;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x30")]
		private IGrabsControllerInput _input;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _initialPosition;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x44")]
		private Quaternion _initialRotation;
	}
}

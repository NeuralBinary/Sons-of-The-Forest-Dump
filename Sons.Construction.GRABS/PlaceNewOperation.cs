using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class PlaceNewOperation : Operation
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2DA22C0", Offset = "0x2DA08C0", VA = "0x182DA22C0")]
		public void Init(IGrabsControllerInput input, BlueprintFace bottomFace, float maxPlaceDistance, float rotationSpeed)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2DA2400", Offset = "0x2DA0A00", VA = "0x182DA2400", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2DA29B0", Offset = "0x2DA0FB0", VA = "0x182DA29B0")]
		private void RotateFace(float rotationSpeed, Vector3 pivotToCenterOffset)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2DA2CB0", Offset = "0x2DA12B0", VA = "0x182DA2CB0", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2DA1180", Offset = "0x2D9F780", VA = "0x182DA1180")]
		public PlaceNewOperation()
		{
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x28")]
		private float _rotationSpeed;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x30")]
		private IGrabsControllerInput _input;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x38")]
		private Blueprint _blueprint;
	}
}

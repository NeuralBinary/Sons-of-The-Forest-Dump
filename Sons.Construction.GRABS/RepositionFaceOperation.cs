using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class RepositionFaceOperation : Operation
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2DA4140", Offset = "0x2DA2740", VA = "0x182DA4140")]
		public void Init(VisualModes mode, InteractionPoint fromIp, BlueprintFace face, Transform aimTransform)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2DA44F0", Offset = "0x2DA2AF0", VA = "0x182DA44F0", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2DA4770", Offset = "0x2DA2D70", VA = "0x182DA4770")]
		private void RefreshFacePos(VisualModes mode, Vector3 onFaceForwardAxisPos, bool smooth)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2DA4AE0", Offset = "0x2DA30E0", VA = "0x182DA4AE0")]
		private void RefreshConnectedFaces(VisualModes mode)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2DA51C0", Offset = "0x2DA37C0", VA = "0x182DA51C0", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2DA5510", Offset = "0x2DA3B10", VA = "0x182DA5510", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2DA5890", Offset = "0x2DA3E90", VA = "0x182DA5890")]
		public RepositionFaceOperation()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2DA58A0", Offset = "0x2DA3EA0", VA = "0x182DA58A0")]
		[CompilerGenerated]
		private void <Init>g__PreprocessConnectedFaces|7_0(BlueprintFace targetFace, out List<Vector3> fromPoints, out List<bool> onZAxis, out bool hasFoundation, out bool hasCeiling, out bool hasLeftWall, out bool hasRightWall)
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x28")]
		private float _maxPlaceDistance;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _maxSnapDistance;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _startPos;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x40")]
		private IReadOnlyList<Vector3> _connectedFacesP1;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x48")]
		private IReadOnlyList<bool> _connectedOnZAxis;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _onFaceForwardAxisPos;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x60")]
		private FaceGapsAutoFiller _faceGapsAutoFiller;
	}
}

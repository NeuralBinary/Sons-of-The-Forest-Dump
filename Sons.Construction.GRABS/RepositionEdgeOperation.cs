using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class RepositionEdgeOperation : Operation
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2DA2D60", Offset = "0x2DA1360", VA = "0x182DA2D60")]
		public void Init(VisualModes mode, InteractionPoint initiallyTargetedIp, InteractionPoint ip, Transform aimTransform, bool applyRestriction)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2DA3340", Offset = "0x2DA1940", VA = "0x182DA3340", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2DA35E0", Offset = "0x2DA1BE0", VA = "0x182DA35E0")]
		private void RefreshEdgePos(VisualModes mode, Vector3 onFaceForwardAxisPos, bool smooth)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2DA3CE0", Offset = "0x2DA22E0", VA = "0x182DA3CE0", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2DA3DA0", Offset = "0x2DA23A0", VA = "0x182DA3DA0", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2DA4120", Offset = "0x2DA2720", VA = "0x182DA4120")]
		public RepositionEdgeOperation()
		{
		}

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x28")]
		private readonly float _maxSnapDistance;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x2C")]
		private float _maxPlaceDistance;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _oppositeFaceOriginalPosition;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _originalSize;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _originalPosition;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _originalRotation;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _onFaceForwardAxisPos;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x70")]
		private int _sizeAxisNum;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x78")]
		private FaceStretchingRestriction _faceStretchingRestriction;
	}
}

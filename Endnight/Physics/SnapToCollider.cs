using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[ExecuteAlways]
	public class SnapToCollider : MonoBehaviour
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA9D870", Offset = "0xA9BE70", VA = "0x180A9D870")]
		private void Start()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA9D880", Offset = "0xA9BE80", VA = "0x180A9D880")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA9D890", Offset = "0xA9BE90", VA = "0x180A9D890")]
		private void DoAlign()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA9E0A0", Offset = "0xA9C6A0", VA = "0x180A9E0A0")]
		public SnapToCollider()
		{
		}

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _snapInEditMode;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _autoUpdate;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _rayYOffset;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxRayDistance;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x30")]
		private Transform _cachedTransform;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x38")]
		private bool _initialized;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _originalPosition;
	}
}

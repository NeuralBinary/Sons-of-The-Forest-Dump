using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public class HelicopterBladeFade : MonoBehaviour
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x2EF9F20", Offset = "0x2EF8F20", VA = "0x182EF9F20")]
		private void OnEnable()
		{
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x2EF9F00", Offset = "0x2EF8F00", VA = "0x182EF9F00")]
		private void OnDisable()
		{
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x2EF9C30", Offset = "0x2EF8C30", VA = "0x182EF9C30")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x2EF9F30", Offset = "0x2EF8F30", VA = "0x182EF9F30")]
		private void RestoreSourceMaterials()
		{
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x2EFA330", Offset = "0x2EF9330", VA = "0x182EFA330")]
		private void SetupMaterialInstance()
		{
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x2EFA7E0", Offset = "0x2EF97E0", VA = "0x182EFA7E0")]
		public HelicopterBladeFade()
		{
		}

		// Token: 0x04003F82 RID: 16258
		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Renderer> _targetRenderers;

		// Token: 0x04003F83 RID: 16259
		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minRotationAmount;

		// Token: 0x04003F84 RID: 16260
		[Token(Token = "0x4003F84")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxRotationAmount;

		// Token: 0x04003F85 RID: 16261
		[Token(Token = "0x4003F85")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasPreviouslyRotated;

		// Token: 0x04003F86 RID: 16262
		[Token(Token = "0x4003F86")]
		[FieldOffset(Offset = "0x34")]
		private Quaternion _previousRotation;

		// Token: 0x04003F87 RID: 16263
		[Token(Token = "0x4003F87")]
		[FieldOffset(Offset = "0x48")]
		private List<Material> _sourceMaterials;

		// Token: 0x04003F88 RID: 16264
		[Token(Token = "0x4003F88")]
		[FieldOffset(Offset = "0x50")]
		private List<Material> _materialInstances;

		// Token: 0x04003F89 RID: 16265
		[Token(Token = "0x4003F89")]
		[FieldOffset(Offset = "0x58")]
		private List<Color> _baseColors;

		// Token: 0x04003F8A RID: 16266
		[Token(Token = "0x4003F8A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorId;

		// Token: 0x04003F8B RID: 16267
		[Token(Token = "0x4003F8B")]
		[FieldOffset(Offset = "0x60")]
		private float _rotationOffset;

		// Token: 0x04003F8C RID: 16268
		[Token(Token = "0x4003F8C")]
		[FieldOffset(Offset = "0x64")]
		private float _factor;

		// Token: 0x04003F8D RID: 16269
		[Token(Token = "0x4003F8D")]
		[FieldOffset(Offset = "0x68")]
		private bool _setupMaterialInstances;
	}
}

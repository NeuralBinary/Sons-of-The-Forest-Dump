using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008FE RID: 2302
	[Token(Token = "0x20008FE")]
	public class HelicopterBladeFade : MonoBehaviour
	{
		// Token: 0x0600424A RID: 16970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x3633950", Offset = "0x3631F50", VA = "0x183633950")]
		private void OnEnable()
		{
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424B")]
		[Address(RVA = "0x3633960", Offset = "0x3631F60", VA = "0x183633960")]
		private void OnDisable()
		{
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424C")]
		[Address(RVA = "0x3633980", Offset = "0x3631F80", VA = "0x183633980")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x3633DF0", Offset = "0x36323F0", VA = "0x183633DF0")]
		private void RestoreSourceMaterials()
		{
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424E")]
		[Address(RVA = "0x36342C0", Offset = "0x36328C0", VA = "0x1836342C0")]
		private void SetupMaterialInstance()
		{
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x3634830", Offset = "0x3632E30", VA = "0x183634830")]
		public HelicopterBladeFade()
		{
		}

		// Token: 0x040045AD RID: 17837
		[Token(Token = "0x40045AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Renderer> _targetRenderers;

		// Token: 0x040045AE RID: 17838
		[Token(Token = "0x40045AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minRotationAmount;

		// Token: 0x040045AF RID: 17839
		[Token(Token = "0x40045AF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxRotationAmount;

		// Token: 0x040045B0 RID: 17840
		[Token(Token = "0x40045B0")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasPreviouslyRotated;

		// Token: 0x040045B1 RID: 17841
		[Token(Token = "0x40045B1")]
		[FieldOffset(Offset = "0x34")]
		private Quaternion _previousRotation;

		// Token: 0x040045B2 RID: 17842
		[Token(Token = "0x40045B2")]
		[FieldOffset(Offset = "0x48")]
		private List<Material> _sourceMaterials;

		// Token: 0x040045B3 RID: 17843
		[Token(Token = "0x40045B3")]
		[FieldOffset(Offset = "0x50")]
		private List<Material> _materialInstances;

		// Token: 0x040045B4 RID: 17844
		[Token(Token = "0x40045B4")]
		[FieldOffset(Offset = "0x58")]
		private List<Color> _baseColors;

		// Token: 0x040045B5 RID: 17845
		[Token(Token = "0x40045B5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorId;

		// Token: 0x040045B6 RID: 17846
		[Token(Token = "0x40045B6")]
		[FieldOffset(Offset = "0x60")]
		private float _rotationOffset;

		// Token: 0x040045B7 RID: 17847
		[Token(Token = "0x40045B7")]
		[FieldOffset(Offset = "0x64")]
		private float _factor;

		// Token: 0x040045B8 RID: 17848
		[Token(Token = "0x40045B8")]
		[FieldOffset(Offset = "0x68")]
		private bool _setupMaterialInstances;
	}
}

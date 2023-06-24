using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class KeepOnWaterSurface : MonoBehaviour
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3103820", Offset = "0x3101E20", VA = "0x183103820")]
		private void OnValidate()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3103A90", Offset = "0x3102090", VA = "0x183103A90")]
		private void Update()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3103CF0", Offset = "0x31022F0", VA = "0x183103CF0")]
		private void UpdateActivate()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x3103E20", Offset = "0x3102420", VA = "0x183103E20")]
		private void UpdateDeactivate()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x3103F20", Offset = "0x3102520", VA = "0x183103F20")]
		private void KeepAboveOrUnder()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x3104290", Offset = "0x3102890", VA = "0x183104290")]
		private Vector3 CalculateLocalYPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3104460", Offset = "0x3102A60", VA = "0x183104460")]
		private bool PassesMinDepth(float waterDepth)
		{
			return default(bool);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public KeepOnWaterSurface()
		{
		}

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _positionOffset;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _alignToNormal;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _deactivateTargetNotInWater;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _waterNormal;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x44")]
		private bool _isInWater;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x48")]
		private float _waterLevel;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x4C")]
		private float _waterDepth;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x50")]
		private float _minWaterDepth;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x54")]
		private bool _deactivatedTarget;
	}
}

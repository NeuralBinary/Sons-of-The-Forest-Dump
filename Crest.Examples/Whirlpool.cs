using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class Whirlpool : MonoBehaviour
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9F8B50", Offset = "0x9F7150", VA = "0x1809F8B50")]
		private void UpdateMaterials()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x9F8C30", Offset = "0x9F7230", VA = "0x1809F8C30")]
		private void Start()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000037")]
		private void AddInput<RegisterInputType>(Material material, float radius) where RegisterInputType : Component
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x9F8FF0", Offset = "0x9F75F0", VA = "0x1809F8FF0")]
		private void Update()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x9F9180", Offset = "0x9F7780", VA = "0x1809F9180")]
		public Whirlpool()
		{
		}

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1000f)]
		private float _amplitude;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1000f)]
		[SerializeField]
		private float _radius;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1000f)]
		[SerializeField]
		private float _eyeRadius;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1000f)]
		[SerializeField]
		private float _maxSpeed;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _createDisplacement;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _createFlow;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _createDynWavesDampen;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x38")]
		private Material _flowMaterial;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x40")]
		private Material _displacementMaterial;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x48")]
		private Material _dampDynWavesMaterial;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[AddComponentMenu("Sons/Atmosphere/AmbientLinkedLight")]
	public class AmbientLinkedLight : MonoBehaviour
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2D3AA00", Offset = "0x2D39000", VA = "0x182D3AA00")]
		private void Awake()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2D3AA20", Offset = "0x2D39020", VA = "0x182D3AA20")]
		private void OnValidate()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2D3AD70", Offset = "0x2D39370", VA = "0x182D3AD70")]
		private void Update()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AmbientLinkedLight()
		{
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Light _light;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HDAdditionalLightData _lightData;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minIntensity;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x34")]
		private float _baseIntensity;
	}
}

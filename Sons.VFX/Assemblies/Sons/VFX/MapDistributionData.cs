using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assemblies.Sons.VFX
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[CreateAssetMenu(fileName = "MapDistributionData", menuName = "Sons/Environment/Map Distribution Data")]
	public class MapDistributionData : ScriptableObject
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x317C460", Offset = "0x317AA60", VA = "0x18317C460")]
		private void TestValue()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x317C630", Offset = "0x317AC30", VA = "0x18317C630")]
		public float GetFactor(Vector2 location)
		{
			return 0f;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x317C900", Offset = "0x317AF00", VA = "0x18317C900")]
		private Vector2 GetUvLocation(Vector2 location)
		{
			return default(Vector2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x317C930", Offset = "0x317AF30", VA = "0x18317C930")]
		public bool ShouldActivate(Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x317C970", Offset = "0x317AF70", VA = "0x18317C970")]
		public bool ShouldActivate(Vector3 worldPos, out float factor)
		{
			return default(bool);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x317C9B0", Offset = "0x317AFB0", VA = "0x18317C9B0")]
		public MapDistributionData()
		{
		}

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D _textureLookup;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _mapSize;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minActivateValue;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _offset;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("_test")]
		[SerializeField]
		private Vector2 _testLocation;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ChannelSelect _channel;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SampleType _sampleType;
	}
}

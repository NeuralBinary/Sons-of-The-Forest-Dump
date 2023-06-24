using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	[AddComponentMenu("Sons/Characters/StreamAnimalZoneBake")]
	public class StreamAnimalZoneBake : MonoBehaviour
	{
		// Token: 0x06002FF7 RID: 12279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF7")]
		[Address(RVA = "0x346A990", Offset = "0x3468F90", VA = "0x18346A990")]
		private void BakeAnimalZones()
		{
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x346AB30", Offset = "0x3469130", VA = "0x18346AB30")]
		public StreamAnimalZoneBake()
		{
		}

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _streamObject;

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _areaPerFish;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _verticalOffset;
	}
}

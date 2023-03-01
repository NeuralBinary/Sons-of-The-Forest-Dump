using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	[AddComponentMenu("Sons/Characters/StreamAnimalZoneBake")]
	public class StreamAnimalZoneBake : MonoBehaviour
	{
		// Token: 0x06003642 RID: 13890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x2E9D9D0", Offset = "0x2E9C9D0", VA = "0x182E9D9D0")]
		private void BakeAnimalZones()
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x2E9DB50", Offset = "0x2E9CB50", VA = "0x182E9DB50")]
		public StreamAnimalZoneBake()
		{
		}

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _streamObject;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _areaPerFish;

		// Token: 0x04002E8F RID: 11919
		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _verticalOffset;
	}
}

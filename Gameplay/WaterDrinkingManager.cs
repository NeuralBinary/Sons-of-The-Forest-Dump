using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x20006CE")]
	[AddComponentMenu("Sons/Gameplay/Water Drinking Manager")]
	public class WaterDrinkingManager : MonoBehaviour
	{
		// Token: 0x06002C90 RID: 11408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public WaterDrinkingManager()
		{
		}

		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset _jsonSource;

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WaterDrinkingManager.DrinkingData _result;

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CapsuleCollider> _colliders;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _gameObjects;

		// Token: 0x020006CF RID: 1743
		[Token(Token = "0x20006CF")]
		[Serializable]
		public class DrinkingData
		{
			// Token: 0x06002C91 RID: 11409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C91")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public DrinkingData()
			{
			}

			// Token: 0x040027E2 RID: 10210
			[Token(Token = "0x40027E2")]
			[FieldOffset(Offset = "0x10")]
			public List<WaterDrinkingManager.DrinkingData.Segment> segments;

			// Token: 0x020006D0 RID: 1744
			[Token(Token = "0x20006D0")]
			[Serializable]
			public class Segment
			{
				// Token: 0x06002C92 RID: 11410 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002C92")]
				[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
				public Segment()
				{
				}

				// Token: 0x040027E3 RID: 10211
				[Token(Token = "0x40027E3")]
				[FieldOffset(Offset = "0x10")]
				public List<Vector3> positions;
			}
		}
	}
}

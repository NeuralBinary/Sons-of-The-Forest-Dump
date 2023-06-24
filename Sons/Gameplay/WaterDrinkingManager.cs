using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000807 RID: 2055
	[Token(Token = "0x2000807")]
	[AddComponentMenu("Sons/Gameplay/Water Drinking Manager")]
	public class WaterDrinkingManager : MonoBehaviour
	{
		// Token: 0x06003771 RID: 14193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterDrinkingManager()
		{
		}

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset _jsonSource;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WaterDrinkingManager.DrinkingData _result;

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CapsuleCollider> _colliders;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _gameObjects;

		// Token: 0x02000808 RID: 2056
		[Token(Token = "0x2000808")]
		[Serializable]
		public class DrinkingData
		{
			// Token: 0x06003772 RID: 14194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003772")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DrinkingData()
			{
			}

			// Token: 0x04002FDB RID: 12251
			[Token(Token = "0x4002FDB")]
			[FieldOffset(Offset = "0x10")]
			public List<WaterDrinkingManager.DrinkingData.Segment> segments;

			// Token: 0x02000809 RID: 2057
			[Token(Token = "0x2000809")]
			[Serializable]
			public class Segment
			{
				// Token: 0x06003773 RID: 14195 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003773")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public Segment()
				{
				}

				// Token: 0x04002FDC RID: 12252
				[Token(Token = "0x4002FDC")]
				[FieldOffset(Offset = "0x10")]
				public List<Vector3> positions;
			}
		}
	}
}

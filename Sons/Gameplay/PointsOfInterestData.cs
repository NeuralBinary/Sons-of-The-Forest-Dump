using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x20007C0")]
	[CreateAssetMenu(fileName = "PointsOfInterestData", menuName = "Sons/Data/PointsOfInterest", order = 0)]
	public class PointsOfInterestData : ScriptableObject
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BD")]
		public List<PointsOfInterestData.PointOfInterestData> All
		{
			[Token(Token = "0x6003594")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x6003595")]
		[Address(RVA = "0x34E4070", Offset = "0x34E2670", VA = "0x1834E4070")]
		public bool TryFindPointOfInterest(string pointOfInterestName, out PointsOfInterestData.PointOfInterestData outPointOfInterest)
		{
			return default(bool);
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003596")]
		[Address(RVA = "0x34E41F0", Offset = "0x34E27F0", VA = "0x1834E41F0")]
		public PointsOfInterestData()
		{
		}

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<PointsOfInterestData.PointOfInterestData> _pointsOfInterest;

		// Token: 0x020007C1 RID: 1985
		[Token(Token = "0x20007C1")]
		[Serializable]
		public class PointOfInterestData
		{
			// Token: 0x06003597 RID: 13719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003597")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PointOfInterestData()
			{
			}

			// Token: 0x04002E48 RID: 11848
			[Token(Token = "0x4002E48")]
			[FieldOffset(Offset = "0x10")]
			[FormerlySerializedAs("Name")]
			public string LinkName;

			// Token: 0x04002E49 RID: 11849
			[Token(Token = "0x4002E49")]
			[FieldOffset(Offset = "0x18")]
			public LocalizedString DisplayName;

			// Token: 0x04002E4A RID: 11850
			[Token(Token = "0x4002E4A")]
			[FieldOffset(Offset = "0x20")]
			public bool IsDiscoverable;

			// Token: 0x04002E4B RID: 11851
			[Token(Token = "0x4002E4B")]
			[FieldOffset(Offset = "0x28")]
			[EventRef]
			public string AudioSting;
		}
	}
}

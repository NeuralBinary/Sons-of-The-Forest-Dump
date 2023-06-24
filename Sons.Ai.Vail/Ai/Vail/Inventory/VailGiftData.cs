using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	[CreateAssetMenu(menuName = "Sons/Ai/VailGiftData", fileName = "VirginiaGiftData", order = 0)]
	public class VailGiftData : ScriptableObject
	{
		// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ShowOptionChances()
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x2BBDBE0", Offset = "0x2BBC1E0", VA = "0x182BBDBE0")]
		public float GetCooldownHours()
		{
			return 0f;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x170000D0")]
		public float SentimentPerVisit
		{
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x170000D1")]
		public float MinHoursBetweenVisits
		{
			[Token(Token = "0x6000F6A")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x2BBDC00", Offset = "0x2BBC200", VA = "0x182BBDC00")]
		public VailGiftData.ActorToPlayerGiftItem ChooseGift(float sentiment)
		{
			return null;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void EditorPreviewOptionChances()
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x2BBDEF0", Offset = "0x2BBC4F0", VA = "0x182BBDEF0")]
		public VailGiftData()
		{
		}

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _sentimentPerVisit;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minHoursBetweenVisits;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _cooldownHoursMinMax;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<VailGiftData.ActorToPlayerGiftItem> _virginiaGivePlayer;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		private float _sentiment;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<VailGiftData.PlayerToActorGiftItem> _playerGiveVirginia;

		// Token: 0x0200021F RID: 543
		[Token(Token = "0x200021F")]
		[Serializable]
		public class ActorToPlayerGiftItem
		{
			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00008700 File Offset: 0x00006900
			[Token(Token = "0x170000D2")]
			public float ChanceWeight
			{
				[Token(Token = "0x6000F6E")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x170000D3")]
			public string ItemName
			{
				[Token(Token = "0x6000F6F")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000F70 RID: 3952 RVA: 0x00008718 File Offset: 0x00006918
			[Token(Token = "0x6000F70")]
			[Address(RVA = "0x2BBDF10", Offset = "0x2BBC510", VA = "0x182BBDF10")]
			public bool IsValid(float sentiment)
			{
				return default(bool);
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x2BBDF20", Offset = "0x2BBC520", VA = "0x182BBDF20")]
			private static ValueDropdownList<string> GetItemTypes()
			{
				return null;
			}

			// Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F72")]
			[Address(RVA = "0x2BBDF60", Offset = "0x2BBC560", VA = "0x182BBDF60")]
			private void RunNow()
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00008730 File Offset: 0x00006930
			[Token(Token = "0x170000D4")]
			private bool IsPlaying
			{
				[Token(Token = "0x6000F73")]
				[Address(RVA = "0x2BBE0A0", Offset = "0x2BBC6A0", VA = "0x182BBE0A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F74")]
			[Address(RVA = "0x2BBE120", Offset = "0x2BBC720", VA = "0x182BBE120")]
			public ActorToPlayerGiftItem()
			{
			}

			// Token: 0x0400095C RID: 2396
			[Token(Token = "0x400095C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _vailItemType;

			// Token: 0x0400095D RID: 2397
			[Token(Token = "0x400095D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _count;

			// Token: 0x0400095E RID: 2398
			[Token(Token = "0x400095E")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _chanceWeight;

			// Token: 0x0400095F RID: 2399
			[Token(Token = "0x400095F")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[SerializeField]
			private float _minSentiment;
		}

		// Token: 0x02000220 RID: 544
		[Token(Token = "0x2000220")]
		[Serializable]
		public class PlayerToActorGiftItem
		{
			// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F75")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerToActorGiftItem()
			{
			}

			// Token: 0x04000960 RID: 2400
			[Token(Token = "0x4000960")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[ItemIdPicker(true)]
			private int _itemId;

			// Token: 0x04000961 RID: 2401
			[Token(Token = "0x4000961")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _sentimentBonus;
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Lodding;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.TerrainDetail
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	[Serializable]
	public class GroupDefinition
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047B")]
		public string Name
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x1700047C")]
		private bool HideGroupOptions
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x2D2A500", Offset = "0x2D29500", VA = "0x182D2A500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x2D2A460", Offset = "0x2D29460", VA = "0x182D2A460")]
		public GroupDefinition(string lodName)
		{
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x1700047D")]
		public float GroupRadius
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x2D2A4D0", Offset = "0x2D294D0", VA = "0x182D2A4D0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x2D2A2C0", Offset = "0x2D292C0", VA = "0x182D2A2C0")]
		public float GetTriggerRange()
		{
			return default(float);
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x1700047E")]
		public int MaxCount
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x2D2A560", Offset = "0x2D29560", VA = "0x182D2A560")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x1700047F")]
		public bool DontGroup
		{
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x2D2A4A0", Offset = "0x2D294A0", VA = "0x182D2A4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x17000480")]
		public bool Initialized
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x908B10", Offset = "0x907B10", VA = "0x180908B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x2D2A360", Offset = "0x2D29360", VA = "0x182D2A360")]
		public bool Matches(string poolName)
		{
			return default(bool);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x2D2A370", Offset = "0x2D29370", VA = "0x182D2A370")]
		public void OnValidate()
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x2D2A2F0", Offset = "0x2D292F0", VA = "0x182D2A2F0")]
		public void Initialize()
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x2D2A400", Offset = "0x2D29400", VA = "0x182D2A400")]
		public void RefreshFromLodSettings()
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x2D2A220", Offset = "0x2D29220", VA = "0x182D2A220")]
		public string GetHLodDefinitionId()
		{
			return null;
		}

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LodSettings _lodSettings;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _dontGroup;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_activeRange")]
		[SerializeField]
		private float _triggerRange;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_groupRadius")]
		[SerializeField]
		[FormerlySerializedAs("_maxDistance")]
		private float _groupMaxRadius;

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxCount;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool _useLodSettingsOverride;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x31")]
		private bool _initialized;
	}
}

using System;
using Il2CppDummyDll;
using Sons.Lodding;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.TerrainDetail
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	[Serializable]
	public class GroupDefinition
	{
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048E")]
		public string Name
		{
			[Token(Token = "0x6002168")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x1700048F")]
		private bool HideGroupOptions
		{
			[Token(Token = "0x6002169")]
			[Address(RVA = "0x3328D80", Offset = "0x3327380", VA = "0x183328D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x3328E50", Offset = "0x3327450", VA = "0x183328E50")]
		public GroupDefinition(string lodName)
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x17000490")]
		public float GroupRadius
		{
			[Token(Token = "0x600216B")]
			[Address(RVA = "0x3328EB0", Offset = "0x33274B0", VA = "0x183328EB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x600216C")]
		[Address(RVA = "0x3328EE0", Offset = "0x33274E0", VA = "0x183328EE0")]
		public float GetTriggerRange()
		{
			return 0f;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x17000491")]
		public int MaxCount
		{
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x3328F30", Offset = "0x3327530", VA = "0x183328F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x17000492")]
		public bool DontGroup
		{
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x3328F60", Offset = "0x3327560", VA = "0x183328F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x17000493")]
		public bool Initialized
		{
			[Token(Token = "0x600216F")]
			[Address(RVA = "0xA69240", Offset = "0xA67840", VA = "0x180A69240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x3328F90", Offset = "0x3327590", VA = "0x183328F90")]
		public bool Matches(string poolName)
		{
			return default(bool);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x3329060", Offset = "0x3327660", VA = "0x183329060")]
		public void OnValidate()
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x33291A0", Offset = "0x33277A0", VA = "0x1833291A0")]
		public void Initialize()
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002173")]
		[Address(RVA = "0x33291C0", Offset = "0x33277C0", VA = "0x1833291C0")]
		public void RefreshFromLodSettings()
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002174")]
		[Address(RVA = "0x3329280", Offset = "0x3327880", VA = "0x183329280")]
		public string GetHLodDefinitionId()
		{
			return null;
		}

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LodSettings _lodSettings;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _dontGroup;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("_activeRange")]
		private float _triggerRange;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_maxDistance")]
		[FormerlySerializedAs("_groupRadius")]
		private float _groupMaxRadius;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxCount;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool _useLodSettingsOverride;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x31")]
		private bool _initialized;
	}
}

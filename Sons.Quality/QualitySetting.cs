using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Quality
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public abstract class QualitySetting
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetQualityProfileId(string id)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetQualityProfileId()
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x31179B0", Offset = "0x3115FB0", VA = "0x1831179B0")]
		public bool Matches(QualitySetting compare)
		{
			return default(bool);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void Apply()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public virtual void OnSceneLoaded()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected QualitySetting()
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private string _qualityProfileId;
	}
}

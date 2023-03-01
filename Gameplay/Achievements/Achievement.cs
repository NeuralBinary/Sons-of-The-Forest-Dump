using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	public abstract class Achievement : MonoBehaviour
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[Token(Token = "0x1700060A")]
		public int Id
		{
			[Token(Token = "0x6002FE7")]
			[Address(RVA = "0x5CEF60", Offset = "0x5CDF60", VA = "0x1805CEF60")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060B")]
		public string ApiName
		{
			[Token(Token = "0x6002FE8")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060C")]
		public string ApiStatName
		{
			[Token(Token = "0x6002FE9")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x2E216B0", Offset = "0x2E206B0", VA = "0x182E216B0")]
		public void Reset()
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x2E21670", Offset = "0x2E20670", VA = "0x182E21670")]
		private void OnValidate()
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public virtual void Initialize()
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x2E21640", Offset = "0x2E20640", VA = "0x182E21640")]
		public bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x2E216E0", Offset = "0x2E206E0", VA = "0x182E216E0")]
		public void Unlock()
		{
		}

		// Token: 0x06002FEF RID: 12271
		[Token(Token = "0x6002FEF")]
		protected abstract void TickStat(string statName);

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x2E216C0", Offset = "0x2E206C0", VA = "0x182E216C0", Slot = "6")]
		public virtual void TickAchievement()
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		protected Achievement()
		{
		}

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string _apiName;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected string _apiStatName;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected int _id;
	}
}

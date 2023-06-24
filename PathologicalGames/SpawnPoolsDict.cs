using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x28B4210", Offset = "0x28B2810", VA = "0x1828B4210")]
		public void AddOnCreatedDelegate(string poolName, SpawnPoolsDict.OnCreatedDelegate createdDelegate)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x28B4370", Offset = "0x28B2970", VA = "0x1828B4370")]
		public void RemoveOnCreatedDelegate(string poolName, SpawnPoolsDict.OnCreatedDelegate createdDelegate)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x28B4500", Offset = "0x28B2B00", VA = "0x1828B4500")]
		public SpawnPool Create(string poolName)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x28B45A0", Offset = "0x28B2BA0", VA = "0x1828B45A0")]
		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x28B4800", Offset = "0x28B2E00", VA = "0x1828B4800")]
		private bool assertValidPoolName(string poolName)
		{
			return default(bool);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x28B4960", Offset = "0x28B2F60", VA = "0x1828B4960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x28B4B00", Offset = "0x28B3100", VA = "0x1828B4B00")]
		public bool Destroy(string poolName)
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x28B4C50", Offset = "0x28B3250", VA = "0x1828B4C50")]
		public void DestroyAll()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x28B4EC0", Offset = "0x28B34C0", VA = "0x1828B4EC0")]
		internal void Add(SpawnPool spawnPool)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x28B5030", Offset = "0x28B3630", VA = "0x1828B5030", Slot = "9")]
		public void Add(string key, SpawnPool value)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x28B5080", Offset = "0x28B3680", VA = "0x1828B5080")]
		internal bool Remove(SpawnPool spawnPool, bool logError)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x28B5170", Offset = "0x28B3770", VA = "0x1828B5170", Slot = "10")]
		public bool Remove(string poolName)
		{
			return default(bool);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x1700001F")]
		public int Count
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x28B51C0", Offset = "0x28B37C0", VA = "0x1828B51C0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x28B5200", Offset = "0x28B3800", VA = "0x1828B5200", Slot = "8")]
		public bool ContainsKey(string poolName)
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x28B5270", Offset = "0x28B3870", VA = "0x1828B5270", Slot = "11")]
		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			return default(bool);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x28B52E0", Offset = "0x28B38E0", VA = "0x1828B52E0", Slot = "16")]
		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		// Token: 0x17000020 RID: 32
		[Token(Token = "0x17000020")]
		public SpawnPool this[string key]
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x28B5330", Offset = "0x28B3930", VA = "0x1828B5330", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x28B5410", Offset = "0x28B3A10", VA = "0x1828B5410", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000021")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x28B5460", Offset = "0x28B3A60", VA = "0x1828B5460", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000022")]
		public ICollection<SpawnPool> Values
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x28B54B0", Offset = "0x28B3AB0", VA = "0x1828B54B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000023")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000024")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x28B5500", Offset = "0x28B3B00", VA = "0x1828B5500", Slot = "14")]
		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x28B5550", Offset = "0x28B3B50", VA = "0x1828B5550", Slot = "15")]
		public void Clear()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x28B55A0", Offset = "0x28B3BA0", VA = "0x1828B55A0")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x28B55F0", Offset = "0x28B3BF0", VA = "0x1828B55F0", Slot = "17")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x28B5640", Offset = "0x28B3C40", VA = "0x1828B5640", Slot = "18")]
		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28B5690", Offset = "0x28B3C90", VA = "0x1828B5690", Slot = "19")]
		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x28B5790", Offset = "0x28B3D90", VA = "0x1828B5790", Slot = "20")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x28B5890", Offset = "0x28B3E90", VA = "0x1828B5890")]
		public SpawnPoolsDict()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x10")]
		internal Dictionary<string, SpawnPoolsDict.OnCreatedDelegate> onCreatedDelegates;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, SpawnPool> _pools;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000A8 RID: 168
		[Token(Token = "0x200001C")]
		public delegate void OnCreatedDelegate(SpawnPool pool);
	}
}

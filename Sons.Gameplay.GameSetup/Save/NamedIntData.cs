using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class NamedIntData
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		[JsonProperty]
		public string SaveObjectNameId
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		[JsonProperty]
		public int SaveValue
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x1700000D")]
		[JsonIgnore]
		public bool SaveValueBool
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2FED920", Offset = "0x2FEBF20", VA = "0x182FED920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public int GetInstanceId()
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2FED930", Offset = "0x2FEBF30", VA = "0x182FED930")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void StaticInitialize()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2FED9F0", Offset = "0x2FEBFF0", VA = "0x182FED9F0")]
		public NamedIntData(string saveObjectNameId, int saveValue, bool hasLoaded, bool hasSaved)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2FEDAE0", Offset = "0x2FEC0E0", VA = "0x182FEDAE0")]
		[JsonConstructor]
		public NamedIntData(string saveObjectNameId, int saveValue)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public event Action<NamedIntData> OnValueChanged
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2FEDBC0", Offset = "0x2FEC1C0", VA = "0x182FEDBC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2FEDD30", Offset = "0x2FEC330", VA = "0x182FEDD30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public event Action<NamedIntData> OnValueReinitialized
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2FEDEA0", Offset = "0x2FEC4A0", VA = "0x182FEDEA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2FEE010", Offset = "0x2FEC610", VA = "0x182FEE010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		public event Action<NamedIntData> OnValueSaved
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2FEE180", Offset = "0x2FEC780", VA = "0x182FEE180")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2FEE2F0", Offset = "0x2FEC8F0", VA = "0x182FEE2F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2FEE460", Offset = "0x2FECA60", VA = "0x182FEE460")]
		public bool SetValue(bool newValue)
		{
			return default(bool);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2FEE4D0", Offset = "0x2FECAD0", VA = "0x182FEE4D0")]
		public bool InitializeValue(bool newValue)
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2FEE4F0", Offset = "0x2FECAF0", VA = "0x182FEE4F0")]
		public bool InitializeValue(int newValue)
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2FEE560", Offset = "0x2FECB60", VA = "0x182FEE560")]
		public bool SetValue(int newValue)
		{
			return default(bool);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2FEE5C0", Offset = "0x2FECBC0", VA = "0x182FEE5C0")]
		public void SetHasSaved()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x25B21D0", Offset = "0x25B07D0", VA = "0x1825B21D0")]
		public bool Matches(NamedIntData namedIntData)
		{
			return default(bool);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2FEE5D0", Offset = "0x2FECBD0", VA = "0x182FEE5D0")]
		public bool Matches(string saveObjectNameId)
		{
			return default(bool);
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static System.Random _instanceIdRandomSource;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x1C")]
		private bool _hasLoaded;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x1D")]
		private bool _hasSaved;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x20")]
		private int _lastHandledValue;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _instanceID;
	}
}

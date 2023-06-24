using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	[AddComponentMenu("Sons/Construction/FreeFormStructureLinkerManager")]
	public class FreeFormStructureLinkerManager : SingletonBehaviour<FreeFormStructureLinkerManager>, ISaveGameSerializer<FreeFormStructureLinkerManager.ManagerSavePayload>
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2E4FA80", Offset = "0x2E4E080", VA = "0x182E4FA80")]
		private void Start()
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2E4FC40", Offset = "0x2E4E240", VA = "0x182E4FC40", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2E4FD80", Offset = "0x2E4E380", VA = "0x182E4FD80")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2E4FE80", Offset = "0x2E4E480", VA = "0x182E4FE80")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2E4FED0", Offset = "0x2E4E4D0", VA = "0x182E4FED0")]
		private void OnDestroyingStructure(Structure structure)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2E501D0", Offset = "0x2E4E7D0", VA = "0x182E501D0")]
		public static void Register(FreeFormStructureLinker linker)
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2E50340", Offset = "0x2E4E940", VA = "0x182E50340")]
		public static void Unregister(FreeFormStructureLinker linker)
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2E504B0", Offset = "0x2E4EAB0", VA = "0x182E504B0")]
		public static void OnLinkerStructureSet(FreeFormStructureLinker linker)
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2E50780", Offset = "0x2E4ED80", VA = "0x182E50780")]
		public static void OnLinkerStructureUnset(FreeFormStructureLinker linker)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2E50A10", Offset = "0x2E4F010", VA = "0x182E50A10")]
		public static bool IsSupportingLinkedScrewStructures(Structure structure)
		{
			return default(bool);
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000251")]
		private string SerializedName
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2E50AA0", Offset = "0x2E4F0A0", VA = "0x182E50AA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x17000252")]
		private bool UniqueFile
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x17000253")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x17000254")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2E50AD0", Offset = "0x2E4F0D0", VA = "0x182E50AD0", Slot = "11")]
		private FreeFormStructureLinkerManager.ManagerSavePayload OnSerialize()
		{
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2E50CA0", Offset = "0x2E4F2A0", VA = "0x182E50CA0", Slot = "12")]
		private void OnDeserialize(FreeFormStructureLinkerManager.ManagerSavePayload payload)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2E50D60", Offset = "0x2E4F360", VA = "0x182E50D60")]
		public FreeFormStructureLinkerManager()
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2E50FE0", Offset = "0x2E4F5E0", VA = "0x182E50FE0")]
		[CompilerGenerated]
		internal static void <Sons.Save.ISaveGameSerializer<Construction.FreeFormStructureLinkerManager.ManagerSavePayload>.OnSerialize>g__LoadSerializableLinkerData|24_0(List<FreeFormStructureLinker> linkers, List<FreeFormStructureLinkerManager.LinkerSavePayload> serializablePayload)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2E51270", Offset = "0x2E4F870", VA = "0x182E51270")]
		[CompilerGenerated]
		internal static void <Sons.Save.ISaveGameSerializer<Construction.FreeFormStructureLinkerManager.ManagerSavePayload>.OnDeserialize>g__DeserializeLinkerData|25_0(List<FreeFormStructureLinkerManager.LinkerSavePayload> serializablePayload, List<FreeFormStructureLinker> linkers)
		{
		}

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<FreeFormStructureLinker> NodeLinkers;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<FreeFormStructureLinker> BuiltLinkers;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<Structure, List<FreeFormStructureLinker>> StructureLinkers;

		// Token: 0x02000121 RID: 289
		[Token(Token = "0x2000121")]
		[Serializable]
		public class ManagerSavePayload
		{
			// Token: 0x06000804 RID: 2052 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ManagerSavePayload()
			{
			}

			// Token: 0x040005F5 RID: 1525
			[Token(Token = "0x40005F5")]
			[FieldOffset(Offset = "0x10")]
			public List<FreeFormStructureLinkerManager.LinkerSavePayload> _nodeLinkersData;

			// Token: 0x040005F6 RID: 1526
			[Token(Token = "0x40005F6")]
			[FieldOffset(Offset = "0x18")]
			public List<FreeFormStructureLinkerManager.LinkerSavePayload> _builtLinkersData;
		}

		// Token: 0x02000122 RID: 290
		[Token(Token = "0x2000122")]
		[Serializable]
		public class LinkerSavePayload
		{
			// Token: 0x06000805 RID: 2053 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LinkerSavePayload()
			{
			}

			// Token: 0x040005F7 RID: 1527
			[Token(Token = "0x40005F7")]
			[FieldOffset(Offset = "0x10")]
			public int _typeId;

			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			[FieldOffset(Offset = "0x14")]
			public int _instanceId;
		}
	}
}

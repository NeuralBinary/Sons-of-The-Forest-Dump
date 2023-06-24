using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Serializable]
	public class AstarData
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public static AstarPath active
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x6355D0", Offset = "0x633BD0", VA = "0x1806355D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000090")]
		public NavMeshGraph navmesh
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000091")]
		public GridGraph gridGraph
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000092")]
		public LayerGridGraph layerGridGraph
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000093")]
		public PointGraph pointGraph
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000094")]
		public RecastGraph recastGraph
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000095")]
		public Type[] graphTypes
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000096")]
		private byte[] data
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x6356E0", Offset = "0x633CE0", VA = "0x1806356E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x6357F0", Offset = "0x633DF0", VA = "0x1806357F0")]
			set
			{
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x635920", Offset = "0x633F20", VA = "0x180635920")]
		public byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x635930", Offset = "0x633F30", VA = "0x180635930")]
		public void SetData(byte[] data)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x635940", Offset = "0x633F40", VA = "0x180635940")]
		public void Awake()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x635A90", Offset = "0x634090", VA = "0x180635A90")]
		internal void LockGraphStructure(bool allowAddingGraphs = false)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x635B30", Offset = "0x634130", VA = "0x180635B30")]
		internal void UnlockGraphStructure()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x635C00", Offset = "0x634200", VA = "0x180635C00")]
		private PathProcessor.GraphUpdateLock AssertSafe(bool onlyAddingGraph = false)
		{
			return default(PathProcessor.GraphUpdateLock);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x635EB0", Offset = "0x6344B0", VA = "0x180635EB0")]
		public void GetNodes(Action<GraphNode> callback)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x635F40", Offset = "0x634540", VA = "0x180635F40")]
		public void UpdateShortcuts()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x636520", Offset = "0x634B20", VA = "0x180636520")]
		public void LoadFromCache()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x636710", Offset = "0x634D10", VA = "0x180636710")]
		public byte[] SerializeGraphs()
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x6368B0", Offset = "0x634EB0", VA = "0x1806368B0")]
		public byte[] SerializeGraphs(SerializeSettings settings)
		{
			return null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x636A20", Offset = "0x635020", VA = "0x180636A20")]
		public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum)
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x636BB0", Offset = "0x6351B0", VA = "0x180636BB0")]
		public void DeserializeGraphs()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x636C30", Offset = "0x635230", VA = "0x180636C30")]
		private void ClearGraphs()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x636DA0", Offset = "0x6353A0", VA = "0x180636DA0")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x636DB0", Offset = "0x6353B0", VA = "0x180636DB0")]
		public void DeserializeGraphs(byte[] bytes)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x636E10", Offset = "0x635410", VA = "0x180636E10")]
		public void DeserializeGraphsAdditive(byte[] bytes)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x6371B0", Offset = "0x6357B0", VA = "0x1806371B0")]
		private void DeserializeGraphsPartAdditive(AstarSerializer sr)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x637760", Offset = "0x635D60", VA = "0x180637760")]
		public void FindGraphTypes()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x637A10", Offset = "0x636010", VA = "0x180637A10")]
		[Obsolete("If really necessary. Use System.Type.GetType instead.")]
		public Type GetGraphType(string type)
		{
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x637B10", Offset = "0x636110", VA = "0x180637B10")]
		[Obsolete("Use CreateGraph(System.Type) instead")]
		public NavGraph CreateGraph(string type)
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x637CE0", Offset = "0x6362E0", VA = "0x180637CE0")]
		internal NavGraph CreateGraph(Type type)
		{
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x637E00", Offset = "0x636400", VA = "0x180637E00")]
		[Obsolete("Use AddGraph(System.Type) instead")]
		public NavGraph AddGraph(string type)
		{
			return null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x638010", Offset = "0x636610", VA = "0x180638010")]
		public NavGraph AddGraph(Type type)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x6382C0", Offset = "0x6368C0", VA = "0x1806382C0")]
		private void AddGraph(NavGraph graph)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x6385A0", Offset = "0x636BA0", VA = "0x1806385A0")]
		public bool RemoveGraph(NavGraph graph)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x638740", Offset = "0x636D40", VA = "0x180638740")]
		public static NavGraph GetGraph(GraphNode node)
		{
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x638880", Offset = "0x636E80", VA = "0x180638880")]
		public NavGraph FindGraph(Func<NavGraph, bool> predicate)
		{
			return null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x638940", Offset = "0x636F40", VA = "0x180638940")]
		public NavGraph FindGraphOfType(Type type)
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x638AC0", Offset = "0x6370C0", VA = "0x180638AC0")]
		public NavGraph FindGraphWhichInheritsFrom(Type type)
		{
			return null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x638C40", Offset = "0x637240", VA = "0x180638C40")]
		public IEnumerable FindGraphsOfType(Type type)
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x638D50", Offset = "0x637350", VA = "0x180638D50")]
		public IEnumerable GetUpdateableGraphs()
		{
			return null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x638DF0", Offset = "0x6373F0", VA = "0x180638DF0")]
		[Obsolete("Obsolete because it is not used by the package internally and the use cases are few. Iterate through the graphs array instead.")]
		public IEnumerable GetRaycastableGraphs()
		{
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x638E90", Offset = "0x637490", VA = "0x180638E90")]
		public int GetGraphIndex(NavGraph graph)
		{
			return 0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x638FB0", Offset = "0x6375B0", VA = "0x180638FB0")]
		public AstarData()
		{
		}

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public NavGraph[] graphs;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string dataString;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("data")]
		[SerializeField]
		private byte[] upgradeData;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x58")]
		public TextAsset file_cachedStartup;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x60")]
		public byte[] data_cachedStartup;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public bool cacheStartup;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x70")]
		private List<bool> graphStructureLocked;
	}
}

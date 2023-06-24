using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Areas;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	[Serializable]
	public abstract class VailZoneBase : MonoBehaviour
	{
		// Token: 0x0600098A RID: 2442 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x2B85B30", Offset = "0x2B84130", VA = "0x182B85B30")]
		public string DisplayName()
		{
			return null;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual VailZoneId ZoneType()
		{
			return VailZoneId.CannibalVillage;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "5")]
		public virtual AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "6")]
		public virtual VailActorClassId ClassFilter()
		{
			return VailActorClassId.None;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2B85BC0", Offset = "0x2B841C0", VA = "0x182B85BC0")]
		protected VailWorldSimulation WorldSim()
		{
			return null;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		public int UniqueId()
		{
			return 0;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public virtual bool NeedsSpawner()
		{
			return default(bool);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2B85C00", Offset = "0x2B84200", VA = "0x182B85C00", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2B85DD0", Offset = "0x2B843D0", VA = "0x182B85DD0", Slot = "9")]
		public virtual void Clear()
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public virtual void OnPostLoad(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public virtual void Tick(bool server, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "12")]
		public virtual GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2B85E20", Offset = "0x2B84420", VA = "0x182B85E20", Slot = "13")]
		public virtual void OnLinkSpawner(IVailSpawner zoneSpawner)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x2B85ED0", Offset = "0x2B844D0", VA = "0x182B85ED0")]
		protected void OnSerializeBase(VailWorldSimulation.ZoneData saveData)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2B85F00", Offset = "0x2B84500", VA = "0x182B85F00")]
		protected void OnDeserializeBase(VailWorldSimulation.ZoneData saveData)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public virtual void OnNetworkEvent(VailZoneStateEvent evt)
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void OnActorTeleport(AreaMask oldCaveMask, AreaMask newCaveMask)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x2B85F20", Offset = "0x2B84520", VA = "0x182B85F20", Slot = "16")]
		public virtual bool OnAddActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x2B86020", Offset = "0x2B84620", VA = "0x182B86020", Slot = "17")]
		public virtual bool OnRemoveActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020", Slot = "18")]
		public virtual int GetPopulation()
		{
			return 0;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
		public virtual int GetFamilyId()
		{
			return 0;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2B86110", Offset = "0x2B84710", VA = "0x182B86110", Slot = "20")]
		protected virtual string GetStatus()
		{
			return null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2B86140", Offset = "0x2B84740", VA = "0x182B86140")]
		public IVailSpawner GetRandomSpawner()
		{
			return null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x2B86290", Offset = "0x2B84890", VA = "0x182B86290")]
		protected WorldSimActor SpawnActor(VailWorldSimulation worldSim, IVailSpawner spawner)
		{
			return null;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "21")]
		public virtual bool IsPointInZone(Vector3 pos, float marginDist = 2f, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2B86400", Offset = "0x2B84A00", VA = "0x182B86400", Slot = "22")]
		public virtual float GetBoundsDistance(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "23")]
		public virtual Vector3 GetRandomPointInZone()
		{
			return default(Vector3);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "24")]
		public virtual Vector3 GetCenterPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
		public virtual bool ShouldGuard(WorldSimActor guard)
		{
			return default(bool);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public virtual void AddGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public virtual void RemoveGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public virtual void AddPartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		public virtual void RemovePartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "30")]
		public virtual bool ShouldJoinParty(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "31")]
		public virtual bool ExtraStats(StringBuilder sb)
		{
			return default(bool);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x2B865A0", Offset = "0x2B84BA0", VA = "0x182B865A0", Slot = "32")]
		public virtual string ExtraWorldStats(List<VailZoneBase> zones)
		{
			return null;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2B865D0", Offset = "0x2B84BD0", VA = "0x182B865D0", Slot = "33")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2B86630", Offset = "0x2B84C30", VA = "0x182B86630")]
		[ContextMenu("Regen UniqueId")]
		private void RegenUniqueId()
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2B86660", Offset = "0x2B84C60", VA = "0x182B86660")]
		public void DrawStatsGUI(GUIStyle displayStyle, GUILayoutOption buttonWidth)
		{
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2B86AD0", Offset = "0x2B850D0", VA = "0x182B86AD0")]
		public void DrawDebug(Camera cam)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2B87060", Offset = "0x2B85660", VA = "0x182B87060")]
		protected VailZoneBase()
		{
		}

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x20")]
		private string _displayName;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _uniqueId;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x2C")]
		private int _actorCount;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x30")]
		protected List<IVailSpawner> Spawners;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x38")]
		protected Dictionary<VailActorTypeId, int> TypeCounts;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x40")]
		private StringBuilder _debugString;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x48")]
		protected int _numSpawned;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x4C")]
		protected float _lastSpawnTimeInHours;
	}
}

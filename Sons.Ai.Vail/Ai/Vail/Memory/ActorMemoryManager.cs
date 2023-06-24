using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Influences;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class ActorMemoryManager : MonoBehaviour
	{
		// Token: 0x06000EEF RID: 3823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x2BB1890", Offset = "0x2BAFE90", VA = "0x182BB1890")]
		public static void RegisterActorMemory(ActorMemory actorMemory, StimuliInfluenceDefaults defaults)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x2BB1BC0", Offset = "0x2BB01C0", VA = "0x182BB1BC0")]
		public static void UnregisterActorMemory(ActorMemory memoryReceiver)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x2BB1C40", Offset = "0x2BB0240", VA = "0x182BB1C40")]
		public static void ClearActorMemory(int actorUniqueId)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x2BB1D90", Offset = "0x2BB0390", VA = "0x182BB1D90")]
		public static bool TryEvaluate(int actorUniqueId, Type stimuliType, out StimuliInfluenceValues values)
		{
			return default(bool);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF3")]
		public static void Adjust<T>(int actorUniqueId, Type stimuliType, float delta) where T : Influence
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x2BB1EE0", Offset = "0x2BB04E0", VA = "0x182BB1EE0")]
		public static void Tick()
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x2BB24D0", Offset = "0x2BB0AD0", VA = "0x182BB24D0")]
		public static void OnEvent(Vector3 position, MemoryEvent type)
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x2BB26E0", Offset = "0x2BB0CE0", VA = "0x182BB26E0")]
		public static float Sample(int uniqueId, MemoryEvent type)
		{
			return 0f;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x2BB2780", Offset = "0x2BB0D80", VA = "0x182BB2780")]
		public static int Count(int uniqueId, MemoryEvent type)
		{
			return 0;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x2BB2860", Offset = "0x2BB0E60", VA = "0x182BB2860")]
		public static float SampleShouldFight(int uniqueId, VailActor actor)
		{
			return 0f;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x2BB2980", Offset = "0x2BB0F80", VA = "0x182BB2980")]
		private static MemoryEvent GetCombatMemoryEvent(VailActorTypeId typeId)
		{
			return MemoryEvent.None;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x2BB29D0", Offset = "0x2BB0FD0", VA = "0x182BB29D0")]
		public static void OnPlayerHitActor(Vector3 position, VailActorTypeId typeId)
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x2BB2AA0", Offset = "0x2BB10A0", VA = "0x182BB2AA0")]
		public static void OnPlayerKilledActor(Vector3 position, VailActorTypeId typeId)
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x2BB2B50", Offset = "0x2BB1150", VA = "0x182BB2B50")]
		public static void OnPlayerFireGun(Vector3 position)
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x2BB2BC0", Offset = "0x2BB11C0", VA = "0x182BB2BC0")]
		public static void OnActorHitPlayer(Vector3 position, VailActor actor)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x2BB2C80", Offset = "0x2BB1280", VA = "0x182BB2C80")]
		public static void OnHitByActor(int uniqueId, VailActor actor)
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x2BB2DD0", Offset = "0x2BB13D0", VA = "0x182BB2DD0")]
		public static void OnPlayerPickup(Vector3 position, string itemId)
		{
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x2BB2F60", Offset = "0x2BB1560", VA = "0x182BB2F60")]
		public static void Save(VailWorldSimulation.VailSaveData saveData)
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x2BB35D0", Offset = "0x2BB1BD0", VA = "0x182BB35D0")]
		public static void Load(VailWorldSimulation.VailSaveData saveData)
		{
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ActorMemoryManager()
		{
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ActorMemory> MemoryEventReceivers;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, EventMemoryData> _eventMemoryDatas;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, ActorMemoryManager.InfluenceMemoryData> _influenceMemoryDatas;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x18")]
		private static List<ActorMemoryManager.QueuedEvent> _queuedEvents;

		// Token: 0x0200020A RID: 522
		[Token(Token = "0x200020A")]
		private class InfluenceMemoryData
		{
			// Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x2BB3EA0", Offset = "0x2BB24A0", VA = "0x182BB3EA0")]
			public void Save(List<ActorMemoryManager.InfluenceSaveData> saveData)
			{
			}

			// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x2BB4180", Offset = "0x2BB2780", VA = "0x182BB4180")]
			public void Load(List<ActorMemoryManager.InfluenceSaveData> saveDatas)
			{
			}

			// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x2BB44B0", Offset = "0x2BB2AB0", VA = "0x182BB44B0")]
			public InfluenceMemoryData()
			{
			}

			// Token: 0x0400090A RID: 2314
			[Token(Token = "0x400090A")]
			[FieldOffset(Offset = "0x10")]
			public readonly Dictionary<Type, StimuliInfluenceValues> TypeMemory;
		}

		// Token: 0x0200020B RID: 523
		[Token(Token = "0x200020B")]
		private struct QueuedEvent
		{
			// Token: 0x0400090B RID: 2315
			[Token(Token = "0x400090B")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Position;

			// Token: 0x0400090C RID: 2316
			[Token(Token = "0x400090C")]
			[FieldOffset(Offset = "0xC")]
			public MemoryEvent Type;
		}

		// Token: 0x0200020C RID: 524
		[Token(Token = "0x200020C")]
		[Serializable]
		public class ActorEventSaveData
		{
			// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x2BB4560", Offset = "0x2BB2B60", VA = "0x182BB4560")]
			public ActorEventSaveData()
			{
			}

			// Token: 0x0400090D RID: 2317
			[Token(Token = "0x400090D")]
			[FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x0400090E RID: 2318
			[Token(Token = "0x400090E")]
			[FieldOffset(Offset = "0x18")]
			public List<ActorMemoryManager.EventSaveData> Events;
		}

		// Token: 0x0200020D RID: 525
		[Token(Token = "0x200020D")]
		[Serializable]
		public class EventSaveData
		{
			// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EventSaveData()
			{
			}

			// Token: 0x0400090F RID: 2319
			[Token(Token = "0x400090F")]
			[FieldOffset(Offset = "0x10")]
			public int Count;

			// Token: 0x04000910 RID: 2320
			[Token(Token = "0x4000910")]
			[FieldOffset(Offset = "0x14")]
			public float Time;
		}

		// Token: 0x0200020E RID: 526
		[Token(Token = "0x200020E")]
		[Serializable]
		public class InfluenceSaveData
		{
			// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F09")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public InfluenceSaveData()
			{
			}

			// Token: 0x04000911 RID: 2321
			[Token(Token = "0x4000911")]
			[FieldOffset(Offset = "0x10")]
			public string TypeId;

			// Token: 0x04000912 RID: 2322
			[Token(Token = "0x4000912")]
			[FieldOffset(Offset = "0x18")]
			public float Sentiment;

			// Token: 0x04000913 RID: 2323
			[Token(Token = "0x4000913")]
			[FieldOffset(Offset = "0x1C")]
			public float Anger;

			// Token: 0x04000914 RID: 2324
			[Token(Token = "0x4000914")]
			[FieldOffset(Offset = "0x20")]
			public float Fear;
		}

		// Token: 0x0200020F RID: 527
		[Token(Token = "0x200020F")]
		[Serializable]
		public class ActorInfluenceSaveData
		{
			// Token: 0x06000F0A RID: 3850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F0A")]
			[Address(RVA = "0x2BB4610", Offset = "0x2BB2C10", VA = "0x182BB4610")]
			public ActorInfluenceSaveData()
			{
			}

			// Token: 0x04000915 RID: 2325
			[Token(Token = "0x4000915")]
			[FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x04000916 RID: 2326
			[Token(Token = "0x4000916")]
			[FieldOffset(Offset = "0x18")]
			public List<ActorMemoryManager.InfluenceSaveData> Influences;
		}
	}
}

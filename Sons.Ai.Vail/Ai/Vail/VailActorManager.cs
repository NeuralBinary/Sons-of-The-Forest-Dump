using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[AddComponentMenu("Sons/Ai/Vail Actor Manager")]
	public class VailActorManager : MonoBehaviour
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public static bool ActorsHidden
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x2AFD900", Offset = "0x2AFBF00", VA = "0x182AFD900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x2AFD950", Offset = "0x2AFBF50", VA = "0x182AFD950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2AFD9B0", Offset = "0x2AFBFB0", VA = "0x182AFD9B0")]
		public static VailActorManager Initialize([Optional] VailWorldSimulation worldSim)
		{
			return null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2AFDE30", Offset = "0x2AFC430", VA = "0x182AFDE30")]
		public bool AtMaxActiveForType(VailActorTypeId typeId, bool animalsEnabled, VailActorPools actorPools)
		{
			return default(bool);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2AFE2C0", Offset = "0x2AFC8C0", VA = "0x182AFE2C0")]
		private static void UpdateTypeCounts(VailActor actor, int delta)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2AFE550", Offset = "0x2AFCB50", VA = "0x182AFE550")]
		public static void Register(VailActor actor)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2AFE6C0", Offset = "0x2AFCCC0", VA = "0x182AFE6C0")]
		public static void Unregister(VailActor actor)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2AFE860", Offset = "0x2AFCE60", VA = "0x182AFE860")]
		public static void Register(EventStimuli eventStimuli)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2AFE8F0", Offset = "0x2AFCEF0", VA = "0x182AFE8F0")]
		public static void Unregister(EventStimuli eventStimuli)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2AFEA60", Offset = "0x2AFD060", VA = "0x182AFEA60")]
		public static void Register(AuraInfluence aura)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2AFEAF0", Offset = "0x2AFD0F0", VA = "0x182AFEAF0")]
		public static void Unregister(AuraInfluence aura)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000361")]
		private static bool RegisterInternal<T>(T registerItem, ref List<T> targetList)
		{
			return default(bool);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		private static void UnregisterInternal<T>(T registerItem, ref List<T> targetList)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2AFEC60", Offset = "0x2AFD260", VA = "0x182AFEC60")]
		public static int GetNextTickOffset()
		{
			return 0;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2AFECB0", Offset = "0x2AFD2B0", VA = "0x182AFECB0")]
		public static void ClearAll()
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2AFED10", Offset = "0x2AFD310", VA = "0x182AFED10")]
		public void ClearAllInternal()
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2AFEF90", Offset = "0x2AFD590", VA = "0x182AFEF90")]
		public static void RemoveDeadBodies()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2AFEFF0", Offset = "0x2AFD5F0", VA = "0x182AFEFF0")]
		public static void RemoveActors(VailActorClassId classId = VailActorClassId.None)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2AFF060", Offset = "0x2AFD660", VA = "0x182AFF060")]
		public static void RemoveActors(VailActorTypeId typeId)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2AFF0D0", Offset = "0x2AFD6D0", VA = "0x182AFF0D0")]
		public static void RemoveActor(VailActor actor)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2AFF260", Offset = "0x2AFD860", VA = "0x182AFF260")]
		public static void RemoveActorsFromSpawner(IVailSpawner spawner)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2AFF3F0", Offset = "0x2AFD9F0", VA = "0x182AFF3F0")]
		private void RemoveDead()
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2AFF9C0", Offset = "0x2AFDFC0", VA = "0x182AFF9C0")]
		private void RemoveActors(VailActorTypeId typeId, VailActorClassId classId)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2AFFC60", Offset = "0x2AFE260", VA = "0x182AFFC60")]
		private void RemoveActorInternal(VailActor actor)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2AFFDA0", Offset = "0x2AFE3A0", VA = "0x182AFFDA0")]
		private void RemoveFromSpawner(IVailSpawner spawner)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2AFFEE0", Offset = "0x2AFE4E0", VA = "0x182AFFEE0")]
		private void DestroyActor(VailActor actor)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2AFFFA0", Offset = "0x2AFE5A0", VA = "0x182AFFFA0")]
		public static VailActor[] GetActiveActors()
		{
			return null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2B00120", Offset = "0x2AFE720", VA = "0x182B00120")]
		public static void OnSave()
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2B00390", Offset = "0x2AFE990", VA = "0x182B00390")]
		public static VailActor FindActiveActor(WorldSimActor actor)
		{
			return null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2B005B0", Offset = "0x2AFEBB0", VA = "0x182B005B0")]
		public static VailActor[] GetActiveActorsOfType(VailController controller)
		{
			return null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2B00890", Offset = "0x2AFEE90", VA = "0x182B00890")]
		private void Cleanup()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2B00930", Offset = "0x2AFEF30", VA = "0x182B00930")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		private static void RemoveNulls<T>(ref List<T> targetList)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2B00A90", Offset = "0x2AFF090", VA = "0x182B00A90")]
		public static void OnPaused(bool paused)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2B00D50", Offset = "0x2AFF350", VA = "0x182B00D50")]
		public static void HideActors(bool value)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2B01100", Offset = "0x2AFF700", VA = "0x182B01100")]
		private static float GetDeadBodyDestroyTimeSeconds(VailActorTypeId typeId)
		{
			return 0f;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2B01150", Offset = "0x2AFF750", VA = "0x182B01150")]
		public static float GetAnimSpeed()
		{
			return 0f;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2B01200", Offset = "0x2AFF800", VA = "0x182B01200")]
		public static void DebugSetAnimSpeed(float speed)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2B01500", Offset = "0x2AFFB00", VA = "0x182B01500")]
		public void ClearPerf()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2B01530", Offset = "0x2AFFB30", VA = "0x182B01530")]
		public void DeactivateAllLivingActors()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2B017B0", Offset = "0x2AFFDB0", VA = "0x182B017B0")]
		public void DeactivateOrDestroyActors()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2B01990", Offset = "0x2AFFF90", VA = "0x182B01990")]
		public void TickServer()
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2B01CF0", Offset = "0x2B002F0", VA = "0x182B01CF0")]
		private void TickNetworkActorsServer()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2B01F80", Offset = "0x2B00580", VA = "0x182B01F80")]
		public void TickClient()
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2B02500", Offset = "0x2B00B00", VA = "0x182B02500")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2B02890", Offset = "0x2B00E90", VA = "0x182B02890")]
		private void UpdateActors()
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2B02D30", Offset = "0x2B01330", VA = "0x182B02D30")]
		private void UpdateActorMovement()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2B03780", Offset = "0x2B01D80", VA = "0x182B03780")]
		private void UpdateEvents()
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2B03DF0", Offset = "0x2B023F0", VA = "0x182B03DF0")]
		private void UpdateAuras()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2B04410", Offset = "0x2B02A10", VA = "0x182B04410")]
		private void UpdateDebugPaths()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2B04650", Offset = "0x2B02C50", VA = "0x182B04650")]
		public static bool OverlapsActor(Vector3 position, float radius, [Optional] VailActor ignoreActor)
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2B04A40", Offset = "0x2B03040", VA = "0x182B04A40")]
		public static bool IsPlayerInCombat(Vector3 position, float combatDist = 30f, float nearDist = 8f)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2B04D80", Offset = "0x2B03380", VA = "0x182B04D80")]
		public static VailActor GetClosestActor(Vector3 position, float maxRadius = 120f)
		{
			return null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2B04EF0", Offset = "0x2B034F0", VA = "0x182B04EF0")]
		public static bool IsActorInCone(Vector3 position, Vector3 lookDir, float distance, float coneAngle, VailActorClassId ignoreClassId = VailActorClassId.None)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2B052A0", Offset = "0x2B038A0", VA = "0x182B052A0")]
		public static bool IsPlayerFacingEnemy(Transform playerTr, float dist = 2.5f, float coneAngle = 45f)
		{
			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2B053E0", Offset = "0x2B039E0", VA = "0x182B053E0")]
		public bool TryFindActorsInRadius(Vector3 position, float radius, out List<VailActor> actors)
		{
			return default(bool);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2B05550", Offset = "0x2B03B50", VA = "0x182B05550")]
		public static int FindNearbyFriendCount(VailActor actor, float radius)
		{
			return 0;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2B05880", Offset = "0x2B03E80", VA = "0x182B05880")]
		public void KillActor(VailActor actor)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2B059E0", Offset = "0x2B03FE0", VA = "0x182B059E0")]
		public int KillActorsInRadius(Vector3 position, float radius, VailActorClassId classId = VailActorClassId.None)
		{
			return 0;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2B05C20", Offset = "0x2B04220", VA = "0x182B05C20")]
		public void IgniteActorsInRadius(Vector3 position, float radius, float lifetime, bool onlyBurnDeadBody = true)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2B05E70", Offset = "0x2B04470", VA = "0x182B05E70")]
		public void DismemberActorsInRadius(Vector3 position, float radius, float lifetime)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2B06050", Offset = "0x2B04650", VA = "0x182B06050")]
		public void DamageActorsInRadius(Vector3 position, float radius, float damage)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2B06240", Offset = "0x2B04840", VA = "0x182B06240")]
		public static List<MonoBehaviourStimuli> GetAudioEvents(Vector3 position, float radius)
		{
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2B06500", Offset = "0x2B04B00", VA = "0x182B06500")]
		public void NewAttackStructureStimuli(VailActor actor, Vector3 position, Transform parentTr)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2B06590", Offset = "0x2B04B90", VA = "0x182B06590")]
		public void ClearActorManagedStimuli(VailActor actor)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000397")]
		private MonoBehaviourStimuli NewStimuliForActor<T>(ref Dictionary<int, T> dictionary, VailActor actor, Vector3 position, Transform parentTr) where T : StructureAttackStimuli
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		private void ClearStimuliForActor<T>(Dictionary<int, T> dictionary, int uniqueId) where T : MonoBehaviourStimuli
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2B06720", Offset = "0x2B04D20", VA = "0x182B06720")]
		public static void OnPlayerSleep(Vector3 playerPos)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2B06B60", Offset = "0x2B05160", VA = "0x182B06B60")]
		public void ServerUpdateNetworkRelevantActors()
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public static bool VerboseProfile
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2B07100", Offset = "0x2B05700", VA = "0x182B07100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2B07150", Offset = "0x2B05750", VA = "0x182B07150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public static bool VerboseDebug
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2B071B0", Offset = "0x2B057B0", VA = "0x182B071B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2B07200", Offset = "0x2B05800", VA = "0x182B07200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2B07260", Offset = "0x2B05860", VA = "0x182B07260")]
		public static void SetVerboseDebug(bool value)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public static bool VailStats
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2B072F0", Offset = "0x2B058F0", VA = "0x182B072F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2B07340", Offset = "0x2B05940", VA = "0x182B07340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2B073A0", Offset = "0x2B059A0", VA = "0x182B073A0")]
		public static void ShowVailStats(bool value)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public static bool VisualLods
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2B07430", Offset = "0x2B05A30", VA = "0x182B07430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2B07480", Offset = "0x2B05A80", VA = "0x182B07480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2B074E0", Offset = "0x2B05AE0", VA = "0x182B074E0")]
		public static void SetVisualLodsEnabled(bool value)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public static bool CriticalOnly
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x2B07570", Offset = "0x2B05B70", VA = "0x182B07570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2B075C0", Offset = "0x2B05BC0", VA = "0x182B075C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2B07620", Offset = "0x2B05C20", VA = "0x182B07620")]
		public static void SetCriticalOnly(bool value)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public static bool GhostPlayer
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x2B076B0", Offset = "0x2B05CB0", VA = "0x182B076B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x2B07700", Offset = "0x2B05D00", VA = "0x182B07700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2B07760", Offset = "0x2B05D60", VA = "0x182B07760")]
		public static void SetGhostPlayer(bool value)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public static bool ForceStrafe
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x2B077F0", Offset = "0x2B05DF0", VA = "0x182B077F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2B07840", Offset = "0x2B05E40", VA = "0x182B07840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2B078A0", Offset = "0x2B05EA0", VA = "0x182B078A0")]
		public static void SetForceStrafe(bool value)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public static bool ShowPaths
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x2B07930", Offset = "0x2B05F30", VA = "0x182B07930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x2B07980", Offset = "0x2B05F80", VA = "0x182B07980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2B079E0", Offset = "0x2B05FE0", VA = "0x182B079E0")]
		public static void SetShowPaths(bool value)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public static int DebugThoughtIndex
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2B07A70", Offset = "0x2B06070", VA = "0x182B07A70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2B07AC0", Offset = "0x2B060C0", VA = "0x182B07AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000227A File Offset: 0x0000047A
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public static string DebugGroupName
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x2B07B20", Offset = "0x2B06120", VA = "0x182B07B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2B07B70", Offset = "0x2B06170", VA = "0x182B07B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public static bool DebugGroupIgnoreCooldown
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x2B07C20", Offset = "0x2B06220", VA = "0x182B07C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2B07C70", Offset = "0x2B06270", VA = "0x182B07C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2B07CD0", Offset = "0x2B062D0", VA = "0x182B07CD0")]
		public static void SetDebugGroupIgnoreCooldown(bool value)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public static bool DebugAutoJump
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2B07D60", Offset = "0x2B06360", VA = "0x182B07D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2B07DB0", Offset = "0x2B063B0", VA = "0x182B07DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2B07E10", Offset = "0x2B06410", VA = "0x182B07E10")]
		public static void SetDebugAutoJump(bool value)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2B07EA0", Offset = "0x2B064A0", VA = "0x182B07EA0")]
		public static void SetAnimalLimitMult(float value)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public static bool DebugVision
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2B07F00", Offset = "0x2B06500", VA = "0x182B07F00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2B07F50", Offset = "0x2B06550", VA = "0x182B07F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2B07FB0", Offset = "0x2B065B0", VA = "0x182B07FB0")]
		public static void SetDebugVision(bool value)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x17000049")]
		public static float DebugAnimSpeed
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2B08040", Offset = "0x2B06640", VA = "0x182B08040")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2B08090", Offset = "0x2B06690", VA = "0x182B08090")]
		public static void ForceThought(string param)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2B08290", Offset = "0x2B06890", VA = "0x182B08290")]
		public static bool IsDebugGroup(string groupName)
		{
			return default(bool);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2B08480", Offset = "0x2B06A80", VA = "0x182B08480")]
		public static void AdjustMemoryStats(string param, MonoBehaviourStimuli forStimuli)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2B085B0", Offset = "0x2B06BB0", VA = "0x182B085B0")]
		private void GetDebugActorList(List<VailActor> actorList)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2B08720", Offset = "0x2B06D20", VA = "0x182B08720")]
		private void SetMemoryStatsInternal(string statType, float value, MonoBehaviourStimuli forStimuli)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2B088E0", Offset = "0x2B06EE0", VA = "0x182B088E0")]
		public static void AdjustActorStats(string param)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2B08A60", Offset = "0x2B07060", VA = "0x182B08A60")]
		private void AdjustActorStatsInternal(string statTypeString, float value)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2B08C50", Offset = "0x2B07250", VA = "0x182B08C50")]
		public static void OnStatsGUI()
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2B08D70", Offset = "0x2B07370", VA = "0x182B08D70")]
		public void OnStatsGUIInternal()
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2B09680", Offset = "0x2B07C80", VA = "0x182B09680")]
		public static void OnWorldOverlaysGUI(VailOverlayType overlayType, string filter = "", [Optional] IStimuli player)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2B097D0", Offset = "0x2B07DD0", VA = "0x182B097D0")]
		public void WorldOverlaysGUIInternal(VailOverlayType overlayType, string filter, IStimuli player)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2B09F80", Offset = "0x2B08580", VA = "0x182B09F80")]
		public static int GetActiveCountForType(VailActorTypeId actorType)
		{
			return 0;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2B0A0D0", Offset = "0x2B086D0", VA = "0x182B0A0D0")]
		public static int GetActiveCountForClass(VailActorClassId actorClass)
		{
			return 0;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2B0A220", Offset = "0x2B08820", VA = "0x182B0A220")]
		public static int GetActiveMuddies()
		{
			return 0;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2B0A340", Offset = "0x2B08940", VA = "0x182B0A340")]
		public static int GetActiveCount()
		{
			return 0;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2B0A4A0", Offset = "0x2B08AA0", VA = "0x182B0A4A0")]
		public static string GetActorThought(int uniqueId)
		{
			return null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2B0A710", Offset = "0x2B08D10", VA = "0x182B0A710")]
		public VailActorManager()
		{
		}

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		private const float UpdateAuraTick = 0.25f;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<EventStimuli> _activeEvents;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<AuraInfluence> _activeAuras;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<VailActor> _activeActors;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VailActorManager _instance;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VailLevelGrid _actorGrid;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VailWorldSimulation _worldSimulation;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<MonoBehaviourStimuli> _tempAudioStimuliList;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<VailActor> _tempActorList;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<VailActor> _tempActorList2;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<VailActor> _actorsToDeactivate;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<VailActor> _actorsToDestroy;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<VailActorTypeId, int> _activeCountByType;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<VailActorClassId, int> _activeCountByClass;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _activeCountMuddies;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _activeCountSmallBirds;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _activeCountLargeBirds;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _activeCountSmallWildlife;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _activeCountLargeWildlife;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _framesBetweenFullTicks;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _framesBetweenFullTicksFar;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int _nextTickOffset;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _lastAuraTickTime;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly PerfStats _perf;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<int, StructureAttackStimuli> _allStructureAttackStimuli;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static float _animalLimitMult;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static float _animSpeedDefault;
	}
}

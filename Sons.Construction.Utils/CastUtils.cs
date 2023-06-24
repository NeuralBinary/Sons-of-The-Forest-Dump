using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Utils
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class CastUtils
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DB6180", Offset = "0x2DB4780", VA = "0x182DB6180")]
		public static void ToggleGizmo(bool showGizmo)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DB61E0", Offset = "0x2DB47E0", VA = "0x182DB61E0")]
		public static void ToggleGizmo(bool showGizmo, Color castColor, Color hitColor)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DB6280", Offset = "0x2DB4880", VA = "0x182DB6280")]
		public static int LineCastAllNonAlloc(Vector3 from, Vector3 to, float radius, out RaycastHit[] hits, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Collide)
		{
			return 0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DB6350", Offset = "0x2DB4950", VA = "0x182DB6350")]
		public static bool LineCastAllNonAlloc(Vector3 from, Vector3 to, float radius, int castLayers, out RaycastHit[] hits, out int hitCount, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Collide)
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DB6420", Offset = "0x2DB4A20", VA = "0x182DB6420")]
		public static int LineCastAllNonAlloc(Vector3 from, Vector3 to, float radius, out RaycastHit[] hits, int castLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Collide)
		{
			return 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2DB6750", Offset = "0x2DB4D50", VA = "0x182DB6750")]
		public static void CastRectangleToGround(Transform target, Vector3 size, Vector3 offsetToCenter, float maxDistance, bool aboveTerrain)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DB69B0", Offset = "0x2DB4FB0", VA = "0x182DB69B0")]
		public static void CastRectangleToGround(Vector3 targetPos, Quaternion targetRot, Vector3 size, Vector3 offsetToCenter, float maxDistance, bool aboveTerrain, out Vector3 castedPos, out Quaternion castedRot)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2DB7E50", Offset = "0x2DB6450", VA = "0x182DB7E50")]
		public static Vector3 CastToGround(Vector3 worldPos, [Optional] Func<Ray, Collider, bool> validateElement, float maxDistance = 8f)
		{
			return default(Vector3);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DB7FC0", Offset = "0x2DB65C0", VA = "0x182DB7FC0")]
		public static Vector3 CastToTerrain(Vector3 worldPos, [Optional] Func<Ray, Collider, bool> validateElement, float maxDistance = 8f)
		{
			return default(Vector3);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DB8130", Offset = "0x2DB6730", VA = "0x182DB8130")]
		public static bool TryCastToLayers(Vector3 worldPos, Vector3 dir, float maxDistance, float radius, int layerMask, out Vector3 hitPos, out Vector3 hitNormal, [Optional] Func<Ray, Collider, bool> validateElement, CastUtils.Filters filters = CastUtils.Filters.StartedInsideAndForwardHits)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DB84A0", Offset = "0x2DB6AA0", VA = "0x182DB84A0")]
		public static bool TryCastToGround(Vector3 worldPos, out Vector3 groundPos, out GameObject groundGo, [Optional] Func<Ray, Collider, bool> validateElement, CastUtils.Filters filters = CastUtils.Filters.StartedInsideAndForwardHits)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DB85A0", Offset = "0x2DB6BA0", VA = "0x182DB85A0")]
		public static bool TryCastToGroundAndWater(Vector3 worldPos, out Vector3 groundPos, out GameObject groundGo, [Optional] Func<Ray, Collider, bool> validateElement, CastUtils.Filters filters = CastUtils.Filters.StartedInsideAndForwardHits)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DB86A0", Offset = "0x2DB6CA0", VA = "0x182DB86A0")]
		public static bool TryCastToTerrain(Vector3 worldPos, out Vector3 groundPos, out GameObject groundGo, [Optional] Func<Ray, Collider, bool> validateElement, CastUtils.Filters filters = CastUtils.Filters.StartedInsideAndForwardHits)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DB87A0", Offset = "0x2DB6DA0", VA = "0x182DB87A0")]
		public static bool TryCastDownToLayers(Vector3 worldPos, out Vector3 groundPos, out GameObject groundGo, int layerMask, [Optional] Func<Ray, Collider, bool> validateElement, CastUtils.Filters filters = CastUtils.Filters.StartedInsideAndForwardHits, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore, float maxDistance = 8f)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DB8C30", Offset = "0x2DB7230", VA = "0x182DB8C30")]
		private static bool TryFindSupportFromHits(int hits, RaycastHit[] hitsBuffer, out int solidGroundIndex, CastUtils.Filters filterOptions, Ray cast, Func<Ray, Collider, bool> validateTarget)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DB9100", Offset = "0x2DB7700", VA = "0x182DB9100")]
		public static bool OverlapSphereCast(Vector3 position, float radius, out Collider c)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DB9300", Offset = "0x2DB7900", VA = "0x182DB9300")]
		public static bool OverlapSphereCast(Vector3 position, float radius, int layers, out Collider c)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2DB94D0", Offset = "0x2DB7AD0", VA = "0x182DB94D0")]
		public static bool OverlapSphereCastAll(Vector3 position, float radius, out Collider[] c, out int hitCount, QueryTriggerInteraction triggerMode)
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2DB9590", Offset = "0x2DB7B90", VA = "0x182DB9590")]
		public static bool OverlapSphereCastAll(Vector3 position, float radius, int layers, out Collider[] c, out int hitCount, QueryTriggerInteraction triggerMode)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021D0 File Offset: 0x000003D0
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2DB9750", Offset = "0x2DB7D50", VA = "0x182DB9750")]
		public static bool SphereCast(Vector3 from, Vector3 axis, float distance, float radius, int layerMask, out Collider c)
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021E8 File Offset: 0x000003E8
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2DB9930", Offset = "0x2DB7F30", VA = "0x182DB9930")]
		public static bool SphereCast(Vector3 from, Vector3 to, float radius, int layerMask, out Collider c)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002200 File Offset: 0x00000400
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2DB9CF0", Offset = "0x2DB82F0", VA = "0x182DB9CF0")]
		public static bool SphereCast(Vector3 from, Vector3 axis, float distance, float radius, int layerMask, out Collider c, out Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		public static void LookupStructuresToList<T>(Vector3 castPos, float castRadius, List<T> structureList)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002218 File Offset: 0x00000418
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DB9F00", Offset = "0x2DB8500", VA = "0x182DB9F00")]
		public static bool OverlapBoxCastAll(Vector3 position, Quaternion rotation, Vector3 halfExtents, int layers, out Collider[] c, out int hitCount, QueryTriggerInteraction triggerMode)
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002230 File Offset: 0x00000430
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DBA180", Offset = "0x2DB8780", VA = "0x182DBA180")]
		public static bool OverlapCapsuleCastAll(Vector3 from, Vector3 to, float radius, out Collider[] c, out int hitCount, QueryTriggerInteraction triggerMode)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002248 File Offset: 0x00000448
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DBA260", Offset = "0x2DB8860", VA = "0x182DBA260")]
		public static bool OverlapCapsuleCastAll(Vector3 from, Vector3 to, float radius, int layers, out Collider[] c, out int hitCount, QueryTriggerInteraction triggerMode)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DBA510", Offset = "0x2DB8B10", VA = "0x182DBA510")]
		public static void LookupPlayersToList(Vector3 castPos, Quaternion rotation, Vector3 size, List<GameObject> playerList)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002260 File Offset: 0x00000460
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2DBA8B0", Offset = "0x2DB8EB0", VA = "0x182DBA8B0")]
		public static bool OverlapsAnyPlayer(Vector3 castPos, Quaternion rotation, Vector3 size)
		{
			return default(bool);
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly LayerMask CastLayersExceptTerrain;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly LayerMask CastLayers;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool ShowGizmo;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Color CastColor;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Color HitColor;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static RaycastHit[] HitsBuffer;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Collider[] castResults;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[Flags]
		public enum Filters
		{
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			None = 0,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			CheckElementGroundStatus = 2,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			IgnoreIfCastStartedInside = 4,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			ForwardHitsOnly = 32,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			CancelInWater = 64,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			IgnoreDynamic = 128,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			GroundStatusAndStartedInside = 134,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			GroundStatusAndForwardHits = 162,
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			StartedInsideAndForwardHits = 164,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			ForwardHitsAndIgnoreDynamic = 160
		}
	}
}

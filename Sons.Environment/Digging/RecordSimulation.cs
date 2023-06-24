using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class RecordSimulation : MonoBehaviour
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2FAFB00", Offset = "0x2FAE100", VA = "0x182FAFB00")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2FAFB10", Offset = "0x2FAE110", VA = "0x182FAFB10")]
		private void CollectKeys(bool finalize = false)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2FAFD70", Offset = "0x2FAE370", VA = "0x182FAFD70")]
		private void CollectKeysRecursive(float frameTime, string relativePath, Transform targetTransform)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2FB00D0", Offset = "0x2FAE6D0", VA = "0x182FB00D0")]
		private void CollectKeys(float frameTime, string relativePath, Transform targetTransform)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2FB0380", Offset = "0x2FAE980", VA = "0x182FB0380")]
		private void CollectAndAssign(float frameTime, string relativePath, string propertyName, string[] vectorIds, Vector3 sourceVector, AnimationCurve[] animationCurves, int startIndex)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2FB06A0", Offset = "0x2FAECA0", VA = "0x182FB06A0")]
		private void CollectAndAssign(float frameTime, string relativePath, string propertyName, string[] vectorIds, Vector4 sourceVector, AnimationCurve[] animationCurves, int startIndex)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2FB09B0", Offset = "0x2FAEFB0", VA = "0x182FB09B0")]
		private void CollectAndAssign(float frameTime, string relativePath, string propertyName, string[] vectorIds, Quaternion sourceVector, AnimationCurve[] animationCurves, int startIndex)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2FB0CC0", Offset = "0x2FAF2C0", VA = "0x182FB0CC0")]
		private void AssignToClip(float frameTime, string relativePath, string[] vectorIds, AnimationCurve[] animationCurves, int startIndex, float[] values, string[] combinedKeys)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2FB0F50", Offset = "0x2FAF550", VA = "0x182FB0F50")]
		private void OnDisable()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2FB0F60", Offset = "0x2FAF560", VA = "0x182FB0F60")]
		private void AddKeySetup(Transform sourceTransform)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2FB1400", Offset = "0x2FAFA00", VA = "0x182FB1400")]
		private void GetKeys(string propertyName, string[] vectorIds, Vector3 vector, out string[] combinedKeys, out float[] values)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2FB1620", Offset = "0x2FAFC20", VA = "0x182FB1620")]
		private void GetKeys(string propertyName, string[] vectorIds, Vector4 vector, out string[] combinedKeys, out float[] values)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2FB1880", Offset = "0x2FAFE80", VA = "0x182FB1880")]
		private void GetKeys(string propertyName, string[] vectorIds, Quaternion vector, out string[] combinedKeys, out float[] values)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2FB1AE0", Offset = "0x2FB00E0", VA = "0x182FB1AE0")]
		public RecordSimulation()
		{
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Transform, AnimationCurve[]> _transforms;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _clip;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x30")]
		private float _startTime;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] VectorIdsXYZ;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] VectorIdsXYZW;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string LocalPositionName;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string LocalRotationName;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int PositionStartIndex;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int RotationStartIndex;
	}
}

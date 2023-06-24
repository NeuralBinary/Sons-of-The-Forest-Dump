using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Endnight.Extensions
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public static class AnimatorExtensions
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA9F510", Offset = "0xA9DB10", VA = "0x180A9F510")]
		public static bool IsName(this AnimatorStateInfo animatorStateInfo, int nameHash)
		{
			return default(bool);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA9F520", Offset = "0xA9DB20", VA = "0x180A9F520")]
		public static void SetFloatSafe(this Animator animator, int id, float value)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA9F660", Offset = "0xA9DC60", VA = "0x180A9F660")]
		public static void SetTriggerSafe(this Animator animator, int id)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA9F790", Offset = "0xA9DD90", VA = "0x180A9F790")]
		public static void ResetTriggerSafe(this Animator animator, int id)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA9F8C0", Offset = "0xA9DEC0", VA = "0x180A9F8C0")]
		public static void SetIntegerSafe(this Animator animator, int id, int value)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA9FA00", Offset = "0xA9E000", VA = "0x180A9FA00")]
		public static void SetBoolSafe(this Animator animator, int id, bool value)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA9FB40", Offset = "0xA9E140", VA = "0x180A9FB40")]
		public static bool ValueExists(this Animator animator, int id, AnimatorControllerParameterType paramType)
		{
			return default(bool);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA9FC70", Offset = "0xA9E270", VA = "0x180A9FC70")]
		public static float GetFloatSafe(this Animator animator, int id, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA9FDC0", Offset = "0xA9E3C0", VA = "0x180A9FDC0")]
		public static int GetIntegerSafe(this Animator animator, int id, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA9FF10", Offset = "0xA9E510", VA = "0x180A9FF10")]
		public static bool GetBoolSafe(this Animator animator, int id, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xAA0060", Offset = "0xA9E660", VA = "0x180AA0060")]
		public static void DoCrossFadeFixed(this Animator animator, int nextStateHash, int layer, float fixedTransitionTime, float normalizedTimeOffset)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xAA0130", Offset = "0xA9E730", VA = "0x180AA0130")]
		public static bool HasParam(this Animator target, int paramHash)
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xAA02F0", Offset = "0xA9E8F0", VA = "0x180AA02F0")]
		public static IEnumerator WaitForStateStartThenTransitionExitWorker(this Animator animator, float timeout, int layerIndex, int shortNameHash, [Optional] Action breakAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = true)
		{
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xAA0510", Offset = "0xA9EB10", VA = "0x180AA0510")]
		public static IEnumerator WaitForStateTransitionExitWorker(this Animator animator, float timeout, int layerIndex, int shortNameHash, [Optional] Action breakAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = false)
		{
			return null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xAA0730", Offset = "0xA9ED30", VA = "0x180AA0730")]
		public static IEnumerator WaitForStateStartWorker(this Animator animator, float timeout, int layerIndex, int shortNameHash, [Optional] Action breakAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = true)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xAA0950", Offset = "0xA9EF50", VA = "0x180AA0950")]
		public static IEnumerator WaitForTagEndWorker(this Animator animator, float timeout, int layerIndex, int tagHash, [Optional] Action breakAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = true)
		{
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xAA0B70", Offset = "0xA9F170", VA = "0x180AA0B70")]
		public static IEnumerator WaitForTagStartWorker(this Animator animator, float timeout, int layerIndex, int tagHash, [Optional] Action errorAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = true)
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xAA0D90", Offset = "0xA9F390", VA = "0x180AA0D90")]
		public static IEnumerator WaitForStateOrTagStartWorker(this Animator animator, float timeout, int layerIndex, int tagHash, int shortNameHash, [Optional] Action breakAction, [Optional] Action timeoutAction, [Optional] Action finishAction, [Optional] Action updateAction, bool includeNext = true)
		{
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xAA0FD0", Offset = "0xA9F5D0", VA = "0x180AA0FD0")]
		private static bool TimeoutReached(float timeout, float startTime, Func<float> queryFunction)
		{
			return default(bool);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xAA1020", Offset = "0xA9F620", VA = "0x180AA1020")]
		private static bool GameTimeTimeoutReached(float timeout, float startTime)
		{
			return default(bool);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xAA1180", Offset = "0xA9F780", VA = "0x180AA1180")]
		private static bool RealtimeTimeoutReached(float timeout, float startTime)
		{
			return default(bool);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xAA12E0", Offset = "0xA9F8E0", VA = "0x180AA12E0")]
		private static Dictionary<int, List<int>> GetCache(Animator animator)
		{
			return null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xAA1480", Offset = "0xA9FA80", VA = "0x180AA1480")]
		private static Dictionary<int, List<int>> GetNewCache(Animator animator)
		{
			return null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xAA17E0", Offset = "0xA9FDE0", VA = "0x180AA17E0")]
		public static IEnumerator EnableLayerOverTime(this Animator target, float interval, int layerIndex)
		{
			return null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xAA1890", Offset = "0xA9FE90", VA = "0x180AA1890")]
		public static IEnumerator DisableLayerOverTime(this Animator target, float interval, int layerIndex)
		{
			return null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xAA1940", Offset = "0xA9FF40", VA = "0x180AA1940")]
		public static Quaternion GetRootRotation([NotNull] this Animator target, bool useTransformIfDisabled = true)
		{
			return default(Quaternion);
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Dictionary<int, List<int>>> _cachedParamIds;
	}
}

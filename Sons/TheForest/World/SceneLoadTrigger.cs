using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace TheForest.World
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class SceneLoadTrigger : MonoBehaviour
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x3279740", Offset = "0x3277D40", VA = "0x183279740")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x32799D0", Offset = "0x3277FD0", VA = "0x1832799D0")]
		public void ForceLoad()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x3279A10", Offset = "0x3278010", VA = "0x183279A10")]
		public void ForceUnload()
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetCanLoad(bool canLoad)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x3279A40", Offset = "0x3278040", VA = "0x183279A40")]
		private void DoPendingAction()
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x3279BF0", Offset = "0x32781F0", VA = "0x183279BF0")]
		private void OnActionFinished()
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
		private GameObject GetLoadedSceneRoot()
		{
			return null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x3279C10", Offset = "0x3278210", VA = "0x183279C10")]
		private IEnumerator StreamSceneRoutine()
		{
			return null;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x3279CA0", Offset = "0x32782A0", VA = "0x183279CA0")]
		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x3279FA0", Offset = "0x32785A0", VA = "0x183279FA0")]
		private IEnumerator loadEndBossScene()
		{
			return null;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x327A030", Offset = "0x3278630", VA = "0x18327A030")]
		private IEnumerator UnloadScene()
		{
			return null;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x327A0C0", Offset = "0x32786C0", VA = "0x18327A0C0")]
		private void SceneManager_sceneUnloaded(Scene arg0)
		{
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SceneLoadTrigger()
		{
		}

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x20")]
		public string _triggerTag;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x28")]
		public string _sceneName;

		// Token: 0x04001724 RID: 5924
		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x30")]
		public string _animationPrefabsSceneName;

		// Token: 0x04001725 RID: 5925
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x38")]
		public string _sceneObjectTag;

		// Token: 0x04001726 RID: 5926
		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x40")]
		public string _sceneObjectName;

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x48")]
		public float _loadDelay;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x4C")]
		public float _unloadDelay;

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x50")]
		public bool _canLoad;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x51")]
		public bool _loadAnimPrefabs;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x54")]
		public SceneLoadTrigger.Actions _forwardAction;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x58")]
		public SceneLoadTrigger.Actions _backwardAction;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent _onCrossingForwards;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent _onCrossingBackwards;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent _onBeforeLoad;

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent _onBeforeUnload;

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent _onFinishedLoading;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent _onFinishedUnloading;

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x90")]
		private GameObject _loadedSceneRoot;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x98")]
		private SceneLoadTrigger.Actions _pendingAction;

		// Token: 0x04001735 RID: 5941
		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x9C")]
		private SceneLoadTrigger.Actions _runningAction;

		// Token: 0x0200038A RID: 906
		[Token(Token = "0x200038A")]
		public enum Actions
		{
			// Token: 0x04001737 RID: 5943
			[Token(Token = "0x4001737")]
			None,
			// Token: 0x04001738 RID: 5944
			[Token(Token = "0x4001738")]
			Load,
			// Token: 0x04001739 RID: 5945
			[Token(Token = "0x4001739")]
			Unload,
			// Token: 0x0400173A RID: 5946
			[Token(Token = "0x400173A")]
			DelayedLoad,
			// Token: 0x0400173B RID: 5947
			[Token(Token = "0x400173B")]
			DelayedUnload,
			// Token: 0x0400173C RID: 5948
			[Token(Token = "0x400173C")]
			CrossingEventOnly
		}
	}
}

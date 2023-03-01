using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace TheForest.World
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	public class SceneLoadTrigger : MonoBehaviour
	{
		// Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x2CD1A10", Offset = "0x2CD0A10", VA = "0x182CD1A10")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x2CD1980", Offset = "0x2CD0980", VA = "0x182CD1980")]
		public void ForceLoad()
		{
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x2CD19C0", Offset = "0x2CD09C0", VA = "0x182CD19C0")]
		public void ForceUnload()
		{
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x580620", Offset = "0x57F620", VA = "0x180580620")]
		public void SetCanLoad(bool canLoad)
		{
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x2CD1850", Offset = "0x2CD0850", VA = "0x182CD1850")]
		private void DoPendingAction()
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x2CD19F0", Offset = "0x2CD09F0", VA = "0x182CD19F0")]
		private void OnActionFinished()
		{
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960")]
		private GameObject GetLoadedSceneRoot()
		{
			return null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x2CD1DF0", Offset = "0x2CD0DF0", VA = "0x182CD1DF0")]
		private IEnumerator StreamSceneRoutine()
		{
			return null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x2CD1B80", Offset = "0x2CD0B80", VA = "0x182CD1B80")]
		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x2CD1ED0", Offset = "0x2CD0ED0", VA = "0x182CD1ED0")]
		private IEnumerator loadEndBossScene()
		{
			return null;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x2CD1E60", Offset = "0x2CD0E60", VA = "0x182CD1E60")]
		private IEnumerator UnloadScene()
		{
			return null;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x2CD1D20", Offset = "0x2CD0D20", VA = "0x182CD1D20")]
		private void SceneManager_sceneUnloaded(Scene arg0)
		{
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SceneLoadTrigger()
		{
		}

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		[FieldOffset(Offset = "0x20")]
		public string _triggerTag;

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[FieldOffset(Offset = "0x28")]
		public string _sceneName;

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[FieldOffset(Offset = "0x30")]
		public string _animationPrefabsSceneName;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[FieldOffset(Offset = "0x38")]
		public string _sceneObjectTag;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x40")]
		public string _sceneObjectName;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0x48")]
		public float _loadDelay;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x4C")]
		public float _unloadDelay;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x50")]
		public bool _canLoad;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x51")]
		public bool _loadAnimPrefabs;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x54")]
		public SceneLoadTrigger.Actions _forwardAction;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x58")]
		public SceneLoadTrigger.Actions _backwardAction;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent _onCrossingForwards;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent _onCrossingBackwards;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent _onBeforeLoad;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent _onBeforeUnload;

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent _onFinishedLoading;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent _onFinishedUnloading;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x90")]
		private GameObject _loadedSceneRoot;

		// Token: 0x04001715 RID: 5909
		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x98")]
		private SceneLoadTrigger.Actions _pendingAction;

		// Token: 0x04001716 RID: 5910
		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x9C")]
		private SceneLoadTrigger.Actions _runningAction;

		// Token: 0x02000398 RID: 920
		[Token(Token = "0x2000398")]
		public enum Actions
		{
			// Token: 0x04001718 RID: 5912
			[Token(Token = "0x4001718")]
			None,
			// Token: 0x04001719 RID: 5913
			[Token(Token = "0x4001719")]
			Load,
			// Token: 0x0400171A RID: 5914
			[Token(Token = "0x400171A")]
			Unload,
			// Token: 0x0400171B RID: 5915
			[Token(Token = "0x400171B")]
			DelayedLoad,
			// Token: 0x0400171C RID: 5916
			[Token(Token = "0x400171C")]
			DelayedUnload,
			// Token: 0x0400171D RID: 5917
			[Token(Token = "0x400171D")]
			CrossingEventOnly
		}
	}
}

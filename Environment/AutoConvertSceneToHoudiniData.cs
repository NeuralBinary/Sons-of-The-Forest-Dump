using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	public class AutoConvertSceneToHoudiniData : MonoBehaviour
	{
		// Token: 0x06003059 RID: 12377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003059")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void CreateInstances()
		{
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305A")]
		[Address(RVA = "0x2E216F0", Offset = "0x2E206F0", VA = "0x182E216F0")]
		private Transform GetParentTransform(WorldObjectLocatorData asset)
		{
			return null;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305C")]
		[Address(RVA = "0x2E21820", Offset = "0x2E20820", VA = "0x182E21820")]
		public AutoConvertSceneToHoudiniData()
		{
		}

		// Token: 0x04002A51 RID: 10833
		[Token(Token = "0x4002A51")]
		private const string ProxyPrefix = "[proxy]";

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		private const string EditorOnlyTag = "EditorOnly";

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x04002A54 RID: 10836
		[Token(Token = "0x4002A54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _readOnly;

		// Token: 0x04002A55 RID: 10837
		[Token(Token = "0x4002A55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _ignoreRoots;

		// Token: 0x04002A56 RID: 10838
		[Token(Token = "0x4002A56")]
		[FieldOffset(Offset = "0x38")]
		private TextAsset _outputSelector;

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _outputPath;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_output")]
		[SerializeField]
		[HideInInspector]
		private TextAsset _outputBackup;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _instanceId;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _managedObjects;

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x60")]
		private bool _limitToChildren;

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x64")]
		private Scene _myScene;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x68")]
		private DateTime _lastHierarchyChanged;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0x70")]
		private TextAsset _cachedOutputSelector;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float _duplicateThreshold;

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[FieldOffset(Offset = "0x78")]
		private List<GameObject> _delayRemovedManaged;
	}
}

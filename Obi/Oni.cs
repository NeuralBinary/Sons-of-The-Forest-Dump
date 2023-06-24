using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public static class Oni
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002158 File Offset: 0x00000358
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2734FC0", Offset = "0x27335C0", VA = "0x182734FC0")]
	public static GCHandle PinMemory(object data)
	{
		return default(GCHandle);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2734FD0", Offset = "0x27335D0", VA = "0x182734FD0")]
	public static void UnpinMemory(GCHandle handle)
	{
	}

	// Token: 0x0600001B RID: 27
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2735050", Offset = "0x2733650", VA = "0x182735050")]
	[PreserveSig]
	public static extern void UpdateColliderGrid(float dt);

	// Token: 0x0600001C RID: 28
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x27350D0", Offset = "0x27336D0", VA = "0x1827350D0")]
	[PreserveSig]
	public static extern void SetColliders(IntPtr shapes, IntPtr bounds, IntPtr transforms, int count);

	// Token: 0x0600001D RID: 29
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2735180", Offset = "0x2733780", VA = "0x182735180")]
	[PreserveSig]
	public static extern void SetRigidbodies(IntPtr rigidbodies);

	// Token: 0x0600001E RID: 30
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2735200", Offset = "0x2733800", VA = "0x182735200")]
	[PreserveSig]
	public static extern void SetCollisionMaterials(IntPtr materials);

	// Token: 0x0600001F RID: 31
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2735280", Offset = "0x2733880", VA = "0x182735280")]
	[PreserveSig]
	public static extern void SetTriangleMeshData(IntPtr headers, IntPtr nodes, IntPtr triangles, IntPtr vertices);

	// Token: 0x06000020 RID: 32
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2735330", Offset = "0x2733930", VA = "0x182735330")]
	[PreserveSig]
	public static extern void SetEdgeMeshData(IntPtr headers, IntPtr nodes, IntPtr edges, IntPtr vertices);

	// Token: 0x06000021 RID: 33
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x27353E0", Offset = "0x27339E0", VA = "0x1827353E0")]
	[PreserveSig]
	public static extern void SetDistanceFieldData(IntPtr headers, IntPtr nodes);

	// Token: 0x06000022 RID: 34
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2735470", Offset = "0x2733A70", VA = "0x182735470")]
	[PreserveSig]
	public static extern void SetHeightFieldData(IntPtr headers, IntPtr samples);

	// Token: 0x06000023 RID: 35
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2735500", Offset = "0x2733B00", VA = "0x182735500")]
	[PreserveSig]
	public static extern IntPtr CreateSolver(int capacity);

	// Token: 0x06000024 RID: 36
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2735580", Offset = "0x2733B80", VA = "0x182735580")]
	[PreserveSig]
	public static extern void DestroySolver(IntPtr solver);

	// Token: 0x06000025 RID: 37
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2735600", Offset = "0x2733C00", VA = "0x182735600")]
	[PreserveSig]
	public static extern void SetCapacity(IntPtr solver, int capacity);

	// Token: 0x06000026 RID: 38
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2735690", Offset = "0x2733C90", VA = "0x182735690")]
	[PreserveSig]
	public static extern void InitializeFrame(IntPtr solver, ref Vector4 translation, ref Vector4 scale, ref Quaternion rotation);

	// Token: 0x06000027 RID: 39
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2735740", Offset = "0x2733D40", VA = "0x182735740")]
	[PreserveSig]
	public static extern void UpdateFrame(IntPtr solver, ref Vector4 translation, ref Vector4 scale, ref Quaternion rotation, float dt);

	// Token: 0x06000028 RID: 40
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x27357F0", Offset = "0x2733DF0", VA = "0x1827357F0")]
	[PreserveSig]
	public static extern void ApplyFrame(IntPtr solver, float linearVelocityScale, float angularVelocityScale, float linearInertiaScale, float angularInertiaScale, float dt);

	// Token: 0x06000029 RID: 41
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x27358B0", Offset = "0x2733EB0", VA = "0x1827358B0")]
	[PreserveSig]
	public static extern void RecalculateInertiaTensors(IntPtr solver);

	// Token: 0x0600002A RID: 42
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2735930", Offset = "0x2733F30", VA = "0x182735930")]
	[PreserveSig]
	public static extern void ResetForces(IntPtr solver);

	// Token: 0x0600002B RID: 43
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x27359B0", Offset = "0x2733FB0", VA = "0x1827359B0")]
	[PreserveSig]
	public static extern void SetRigidbodyLinearDeltas(IntPtr solver, IntPtr linearDeltas);

	// Token: 0x0600002C RID: 44
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2735A40", Offset = "0x2734040", VA = "0x182735A40")]
	[PreserveSig]
	public static extern void SetRigidbodyAngularDeltas(IntPtr solver, IntPtr angularDeltas);

	// Token: 0x0600002D RID: 45
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2735AD0", Offset = "0x27340D0", VA = "0x182735AD0")]
	[PreserveSig]
	public static extern void GetBounds(IntPtr solver, ref Vector3 min, ref Vector3 max);

	// Token: 0x0600002E RID: 46
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2735B70", Offset = "0x2734170", VA = "0x182735B70")]
	[PreserveSig]
	public static extern int GetParticleGridSize(IntPtr solver);

	// Token: 0x0600002F RID: 47
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2735BF0", Offset = "0x27341F0", VA = "0x182735BF0")]
	[PreserveSig]
	public static extern void GetParticleGrid(IntPtr solver, Oni.GridCell[] cells);

	// Token: 0x06000030 RID: 48
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2735C90", Offset = "0x2734290", VA = "0x182735C90")]
	[PreserveSig]
	public static extern void SetSolverParameters(IntPtr solver, ref Oni.SolverParameters parameters);

	// Token: 0x06000031 RID: 49
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2735D20", Offset = "0x2734320", VA = "0x182735D20")]
	[PreserveSig]
	public static extern void GetSolverParameters(IntPtr solver, ref Oni.SolverParameters parameters);

	// Token: 0x06000032 RID: 50
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2735DB0", Offset = "0x27343B0", VA = "0x182735DB0")]
	[PreserveSig]
	public static extern int SetActiveParticles(IntPtr solver, int[] active, int num);

	// Token: 0x06000033 RID: 51
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2735E60", Offset = "0x2734460", VA = "0x182735E60")]
	[PreserveSig]
	public static extern IntPtr CollisionDetection(IntPtr solver, float delta_time);

	// Token: 0x06000034 RID: 52
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2735EF0", Offset = "0x27344F0", VA = "0x182735EF0")]
	[PreserveSig]
	public static extern IntPtr Step(IntPtr solver, float step_time, float substep_time, int substeps);

	// Token: 0x06000035 RID: 53
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2735FA0", Offset = "0x27345A0", VA = "0x182735FA0")]
	[PreserveSig]
	public static extern void ApplyPositionInterpolation(IntPtr solver, IntPtr draw_positions, IntPtr draw_orientations, float delta_seconds, float unsimulated_time);

	// Token: 0x06000036 RID: 54
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2736050", Offset = "0x2734650", VA = "0x182736050")]
	[PreserveSig]
	public static extern void UpdateSkeletalAnimation(IntPtr solver);

	// Token: 0x06000037 RID: 55
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x27360D0", Offset = "0x27346D0", VA = "0x1827360D0")]
	[PreserveSig]
	public static extern int GetConstraintCount(IntPtr solver, int type);

	// Token: 0x06000038 RID: 56
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2736160", Offset = "0x2734760", VA = "0x182736160")]
	[PreserveSig]
	public static extern void SetRenderableParticlePositions(IntPtr solver, IntPtr positions);

	// Token: 0x06000039 RID: 57
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x27361F0", Offset = "0x27347F0", VA = "0x1827361F0")]
	[PreserveSig]
	public static extern void SetParticlePhases(IntPtr solver, IntPtr phases);

	// Token: 0x0600003A RID: 58
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2736280", Offset = "0x2734880", VA = "0x182736280")]
	[PreserveSig]
	public static extern void SetParticleCollisionMaterials(IntPtr solver, IntPtr materialIndices);

	// Token: 0x0600003B RID: 59
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2736310", Offset = "0x2734910", VA = "0x182736310")]
	[PreserveSig]
	public static extern void SetParticlePositions(IntPtr solver, IntPtr positions);

	// Token: 0x0600003C RID: 60
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x27363A0", Offset = "0x27349A0", VA = "0x1827363A0")]
	[PreserveSig]
	public static extern void SetParticlePreviousPositions(IntPtr solver, IntPtr prevPositions);

	// Token: 0x0600003D RID: 61
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2736430", Offset = "0x2734A30", VA = "0x182736430")]
	[PreserveSig]
	public static extern void SetParticleOrientations(IntPtr solver, IntPtr orientations);

	// Token: 0x0600003E RID: 62
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x27364C0", Offset = "0x2734AC0", VA = "0x1827364C0")]
	[PreserveSig]
	public static extern void SetParticlePreviousOrientations(IntPtr solver, IntPtr prevOrientations);

	// Token: 0x0600003F RID: 63
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2736550", Offset = "0x2734B50", VA = "0x182736550")]
	[PreserveSig]
	public static extern void SetRenderableParticleOrientations(IntPtr solver, IntPtr orientations);

	// Token: 0x06000040 RID: 64
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x27365E0", Offset = "0x2734BE0", VA = "0x1827365E0")]
	[PreserveSig]
	public static extern void SetParticleInverseMasses(IntPtr solver, IntPtr invMasses);

	// Token: 0x06000041 RID: 65
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2736670", Offset = "0x2734C70", VA = "0x182736670")]
	[PreserveSig]
	public static extern void SetParticleInverseRotationalMasses(IntPtr solver, IntPtr invRotMasses);

	// Token: 0x06000042 RID: 66
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2736700", Offset = "0x2734D00", VA = "0x182736700")]
	[PreserveSig]
	public static extern void SetParticlePrincipalRadii(IntPtr solver, IntPtr principalRadii);

	// Token: 0x06000043 RID: 67
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2736790", Offset = "0x2734D90", VA = "0x182736790")]
	[PreserveSig]
	public static extern void SetParticleVelocities(IntPtr solver, IntPtr velocities);

	// Token: 0x06000044 RID: 68
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2736820", Offset = "0x2734E20", VA = "0x182736820")]
	[PreserveSig]
	public static extern void SetParticleAngularVelocities(IntPtr solver, IntPtr angularVelocities);

	// Token: 0x06000045 RID: 69
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x27368B0", Offset = "0x2734EB0", VA = "0x1827368B0")]
	[PreserveSig]
	public static extern void SetParticleExternalForces(IntPtr solver, IntPtr forces);

	// Token: 0x06000046 RID: 70
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2736940", Offset = "0x2734F40", VA = "0x182736940")]
	[PreserveSig]
	public static extern void SetParticleExternalTorques(IntPtr solver, IntPtr torques);

	// Token: 0x06000047 RID: 71
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x27369D0", Offset = "0x2734FD0", VA = "0x1827369D0")]
	[PreserveSig]
	public static extern void SetParticleWinds(IntPtr solver, IntPtr winds);

	// Token: 0x06000048 RID: 72
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2736A60", Offset = "0x2735060", VA = "0x182736A60")]
	[PreserveSig]
	public static extern void SetParticlePositionDeltas(IntPtr solver, IntPtr deltas);

	// Token: 0x06000049 RID: 73
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2736AF0", Offset = "0x27350F0", VA = "0x182736AF0")]
	[PreserveSig]
	public static extern void SetParticleOrientationDeltas(IntPtr solver, IntPtr deltas);

	// Token: 0x0600004A RID: 74
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2736B80", Offset = "0x2735180", VA = "0x182736B80")]
	[PreserveSig]
	public static extern void SetParticlePositionConstraintCounts(IntPtr solver, IntPtr counts);

	// Token: 0x0600004B RID: 75
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2736C10", Offset = "0x2735210", VA = "0x182736C10")]
	[PreserveSig]
	public static extern void SetParticleOrientationConstraintCounts(IntPtr solver, IntPtr counts);

	// Token: 0x0600004C RID: 76
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2736CA0", Offset = "0x27352A0", VA = "0x182736CA0")]
	[PreserveSig]
	public static extern void SetParticleNormals(IntPtr solver, IntPtr normals);

	// Token: 0x0600004D RID: 77
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2736D30", Offset = "0x2735330", VA = "0x182736D30")]
	[PreserveSig]
	public static extern void SetParticleInverseInertiaTensors(IntPtr solver, IntPtr tensors);

	// Token: 0x0600004E RID: 78
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2736DC0", Offset = "0x27353C0", VA = "0x182736DC0")]
	[PreserveSig]
	public static extern void SetParticleSmoothingRadii(IntPtr solver, IntPtr radii);

	// Token: 0x0600004F RID: 79
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2736E50", Offset = "0x2735450", VA = "0x182736E50")]
	[PreserveSig]
	public static extern void SetParticleBuoyancy(IntPtr solver, IntPtr buoyancy);

	// Token: 0x06000050 RID: 80
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2736EE0", Offset = "0x27354E0", VA = "0x182736EE0")]
	[PreserveSig]
	public static extern void SetParticleRestDensities(IntPtr solver, IntPtr rest_densities);

	// Token: 0x06000051 RID: 81
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2736F70", Offset = "0x2735570", VA = "0x182736F70")]
	[PreserveSig]
	public static extern void SetParticleViscosities(IntPtr solver, IntPtr viscosities);

	// Token: 0x06000052 RID: 82
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2737000", Offset = "0x2735600", VA = "0x182737000")]
	[PreserveSig]
	public static extern void SetParticleSurfaceTension(IntPtr solver, IntPtr surface_tension);

	// Token: 0x06000053 RID: 83
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2737090", Offset = "0x2735690", VA = "0x182737090")]
	[PreserveSig]
	public static extern void SetParticleVorticityConfinement(IntPtr solver, IntPtr vort_confinement);

	// Token: 0x06000054 RID: 84
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2737120", Offset = "0x2735720", VA = "0x182737120")]
	[PreserveSig]
	public static extern void SetParticleAtmosphericDragPressure(IntPtr solver, IntPtr atmospheric_drag, IntPtr atmospheric_pressure);

	// Token: 0x06000055 RID: 85
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x27371C0", Offset = "0x27357C0", VA = "0x1827371C0")]
	[PreserveSig]
	public static extern void SetParticleDiffusion(IntPtr solver, IntPtr diffusion);

	// Token: 0x06000056 RID: 86
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2737250", Offset = "0x2735850", VA = "0x182737250")]
	[PreserveSig]
	public static extern void SetParticleVorticities(IntPtr solver, IntPtr vorticities);

	// Token: 0x06000057 RID: 87
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x27372E0", Offset = "0x27358E0", VA = "0x1827372E0")]
	[PreserveSig]
	public static extern void SetParticleFluidData(IntPtr solver, IntPtr fluidData);

	// Token: 0x06000058 RID: 88
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2737370", Offset = "0x2735970", VA = "0x182737370")]
	[PreserveSig]
	public static extern void SetParticleUserData(IntPtr solver, IntPtr userData);

	// Token: 0x06000059 RID: 89
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2737400", Offset = "0x2735A00", VA = "0x182737400")]
	[PreserveSig]
	public static extern void SetParticleAnisotropies(IntPtr solver, IntPtr anisotropies);

	// Token: 0x0600005A RID: 90
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2737490", Offset = "0x2735A90", VA = "0x182737490")]
	[PreserveSig]
	public static extern void SetSimplices(IntPtr solver, int[] indices, int pointCount, int edgeCount, int triangleCount);

	// Token: 0x0600005B RID: 91
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2737550", Offset = "0x2735B50", VA = "0x182737550")]
	[PreserveSig]
	public static extern int GetDeformableTriangleCount(IntPtr solver);

	// Token: 0x0600005C RID: 92
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x27375D0", Offset = "0x2735BD0", VA = "0x1827375D0")]
	[PreserveSig]
	public static extern void SetDeformableTriangles(IntPtr solver, int[] indices, int num, int destOffset);

	// Token: 0x0600005D RID: 93
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2737690", Offset = "0x2735C90", VA = "0x182737690")]
	[PreserveSig]
	public static extern int RemoveDeformableTriangles(IntPtr solver, int num, int sourceOffset);

	// Token: 0x0600005E RID: 94
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2737730", Offset = "0x2735D30", VA = "0x182737730")]
	[PreserveSig]
	public static extern void SetConstraintGroupParameters(IntPtr solver, int type, ref Oni.ConstraintParameters parameters);

	// Token: 0x0600005F RID: 95
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x27377D0", Offset = "0x2735DD0", VA = "0x1827377D0")]
	[PreserveSig]
	public static extern void GetConstraintGroupParameters(IntPtr solver, int type, ref Oni.ConstraintParameters parameters);

	// Token: 0x06000060 RID: 96
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2737870", Offset = "0x2735E70", VA = "0x182737870")]
	[PreserveSig]
	public static extern void SetRestPositions(IntPtr solver, IntPtr restPositions);

	// Token: 0x06000061 RID: 97
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2737900", Offset = "0x2735F00", VA = "0x182737900")]
	[PreserveSig]
	public static extern void SetRestOrientations(IntPtr solver, IntPtr restOrientations);

	// Token: 0x06000062 RID: 98
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2737990", Offset = "0x2735F90", VA = "0x182737990")]
	[PreserveSig]
	public static extern IntPtr CreateBatch(int type);

	// Token: 0x06000063 RID: 99
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2737A10", Offset = "0x2736010", VA = "0x182737A10")]
	[PreserveSig]
	public static extern void DestroyBatch(IntPtr batch);

	// Token: 0x06000064 RID: 100
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2737A90", Offset = "0x2736090", VA = "0x182737A90")]
	[PreserveSig]
	public static extern IntPtr AddBatch(IntPtr solver, IntPtr batch);

	// Token: 0x06000065 RID: 101
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2737B20", Offset = "0x2736120", VA = "0x182737B20")]
	[PreserveSig]
	public static extern void RemoveBatch(IntPtr solver, IntPtr batch);

	// Token: 0x06000066 RID: 102
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2737BB0", Offset = "0x27361B0", VA = "0x182737BB0")]
	[PreserveSig]
	public static extern bool EnableBatch(IntPtr batch, bool enabled);

	// Token: 0x06000067 RID: 103
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2737C40", Offset = "0x2736240", VA = "0x182737C40")]
	[PreserveSig]
	public static extern int GetBatchConstraintForces(IntPtr batch, float[] forces, int num, int destOffset);

	// Token: 0x06000068 RID: 104
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2737D00", Offset = "0x2736300", VA = "0x182737D00")]
	[PreserveSig]
	public static extern void SetBatchConstraintCount(IntPtr batch, int num);

	// Token: 0x06000069 RID: 105
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2737D90", Offset = "0x2736390", VA = "0x182737D90")]
	[PreserveSig]
	public static extern int GetBatchConstraintCount(IntPtr batch);

	// Token: 0x0600006A RID: 106
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2737E10", Offset = "0x2736410", VA = "0x182737E10")]
	[PreserveSig]
	public static extern void SetDistanceConstraints(IntPtr batch, IntPtr indices, IntPtr restLengths, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x0600006B RID: 107
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2737EC0", Offset = "0x27364C0", VA = "0x182737EC0")]
	[PreserveSig]
	public static extern void SetBendingConstraints(IntPtr batch, IntPtr indices, IntPtr restBends, IntPtr bendingStiffnesses, IntPtr plasticity, IntPtr lambdas, int num);

	// Token: 0x0600006C RID: 108
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2737F70", Offset = "0x2736570", VA = "0x182737F70")]
	[PreserveSig]
	public static extern void SetSkinConstraints(IntPtr batch, IntPtr indices, IntPtr points, IntPtr normals, IntPtr radiiBackstops, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x0600006D RID: 109
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2738020", Offset = "0x2736620", VA = "0x182738020")]
	[PreserveSig]
	public static extern void SetAerodynamicConstraints(IntPtr batch, IntPtr particleIndices, IntPtr aerodynamicCoeffs, int num);

	// Token: 0x0600006E RID: 110
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x27380D0", Offset = "0x27366D0", VA = "0x1827380D0")]
	[PreserveSig]
	public static extern void SetVolumeConstraints(IntPtr batch, IntPtr triangleIndices, IntPtr firstTriangle, IntPtr numTriangles, IntPtr restVolumes, IntPtr pressureStiffnesses, IntPtr lambdas, int num);

	// Token: 0x0600006F RID: 111
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2738180", Offset = "0x2736780", VA = "0x182738180")]
	[PreserveSig]
	public static extern void SetShapeMatchingConstraints(IntPtr batch, IntPtr shapeIndices, IntPtr firstIndex, IntPtr numIndices, IntPtr explicitGroup, IntPtr materialParameters, IntPtr restComs, IntPtr coms, IntPtr orientations, int num);

	// Token: 0x06000070 RID: 112
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2738230", Offset = "0x2736830", VA = "0x182738230")]
	[PreserveSig]
	public static extern void CalculateRestShapeMatching(IntPtr solver, IntPtr batch);

	// Token: 0x06000071 RID: 113
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x27382C0", Offset = "0x27368C0", VA = "0x1827382C0")]
	[PreserveSig]
	public static extern void SetStretchShearConstraints(IntPtr batch, IntPtr particleIndices, IntPtr orientationIndices, IntPtr restLengths, IntPtr restOrientations, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x06000072 RID: 114
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2738370", Offset = "0x2736970", VA = "0x182738370")]
	[PreserveSig]
	public static extern void SetBendTwistConstraints(IntPtr batch, IntPtr orientationIndices, IntPtr restDarboux, IntPtr stiffnesses, IntPtr plasticity, IntPtr lambdas, int num);

	// Token: 0x06000073 RID: 115
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2738420", Offset = "0x2736A20", VA = "0x182738420")]
	[PreserveSig]
	public static extern void SetTetherConstraints(IntPtr batch, IntPtr indices, IntPtr maxLenghtsScales, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x06000074 RID: 116
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x27384D0", Offset = "0x2736AD0", VA = "0x1827384D0")]
	[PreserveSig]
	public static extern void SetPinConstraints(IntPtr batch, IntPtr indices, IntPtr pinOffsets, IntPtr restDarboux, IntPtr colliders, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x06000075 RID: 117
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2738580", Offset = "0x2736B80", VA = "0x182738580")]
	[PreserveSig]
	public static extern void SetStitchConstraints(IntPtr batch, IntPtr indices, IntPtr stiffnesses, IntPtr lambdas, int num);

	// Token: 0x06000076 RID: 118
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2738630", Offset = "0x2736C30", VA = "0x182738630")]
	[PreserveSig]
	public static extern void SetChainConstraints(IntPtr batch, IntPtr indices, IntPtr lengths, IntPtr firstIndex, IntPtr numIndex, int num);

	// Token: 0x06000077 RID: 119
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x27386E0", Offset = "0x2736CE0", VA = "0x1827386E0")]
	[PreserveSig]
	public static extern void GetCollisionContacts(IntPtr solver, Oni.Contact[] contacts, int n);

	// Token: 0x06000078 RID: 120
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2738790", Offset = "0x2736D90", VA = "0x182738790")]
	[PreserveSig]
	public static extern void GetParticleCollisionContacts(IntPtr solver, Oni.Contact[] contacts, int n);

	// Token: 0x06000079 RID: 121
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2738840", Offset = "0x2736E40", VA = "0x182738840")]
	[PreserveSig]
	public static extern int InterpolateDiffuseParticles(IntPtr solver, IntPtr properties, IntPtr diffusePositions, IntPtr diffuseProperties, IntPtr neighbourCount, int n);

	// Token: 0x0600007A RID: 122
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x27388F0", Offset = "0x2736EF0", VA = "0x1827388F0")]
	[PreserveSig]
	public static extern int MakePhase(int group, Oni.ParticleFlags flags);

	// Token: 0x0600007B RID: 123
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2738980", Offset = "0x2736F80", VA = "0x182738980")]
	[PreserveSig]
	public static extern int GetGroupFromPhase(int phase);

	// Token: 0x0600007C RID: 124
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2738A00", Offset = "0x2737000", VA = "0x182738A00")]
	[PreserveSig]
	public static extern int GetFlagsFromPhase(int phase);

	// Token: 0x0600007D RID: 125
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2738A80", Offset = "0x2737080", VA = "0x182738A80")]
	[PreserveSig]
	public static extern float BendingConstraintRest(float[] constraintCoordinates);

	// Token: 0x0600007E RID: 126
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2738B10", Offset = "0x2737110", VA = "0x182738B10")]
	[PreserveSig]
	public static extern void CompleteAll();

	// Token: 0x0600007F RID: 127
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2738B80", Offset = "0x2737180", VA = "0x182738B80")]
	[PreserveSig]
	public static extern void Complete(IntPtr task);

	// Token: 0x06000080 RID: 128
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2738C00", Offset = "0x2737200", VA = "0x182738C00")]
	[PreserveSig]
	public static extern IntPtr CreateEmpty();

	// Token: 0x06000081 RID: 129
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2738C70", Offset = "0x2737270", VA = "0x182738C70")]
	[PreserveSig]
	public static extern void Schedule(IntPtr task);

	// Token: 0x06000082 RID: 130
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2738CF0", Offset = "0x27372F0", VA = "0x182738CF0")]
	[PreserveSig]
	public static extern void AddChild(IntPtr task, IntPtr child);

	// Token: 0x06000083 RID: 131
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2738D80", Offset = "0x2737380", VA = "0x182738D80")]
	[PreserveSig]
	public static extern int GetMaxSystemConcurrency();

	// Token: 0x06000084 RID: 132
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2738DF0", Offset = "0x27373F0", VA = "0x182738DF0")]
	[PreserveSig]
	public static extern void ClearProfiler();

	// Token: 0x06000085 RID: 133
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2738E60", Offset = "0x2737460", VA = "0x182738E60")]
	[PreserveSig]
	public static extern void EnableProfiler(bool cooked);

	// Token: 0x06000086 RID: 134
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2738EE0", Offset = "0x27374E0", VA = "0x182738EE0")]
	[PreserveSig]
	public static extern void BeginSample(string name, byte type);

	// Token: 0x06000087 RID: 135
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2738F90", Offset = "0x2737590", VA = "0x182738F90")]
	[PreserveSig]
	public static extern void EndSample();

	// Token: 0x06000088 RID: 136
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2739000", Offset = "0x2737600", VA = "0x182739000")]
	[PreserveSig]
	public static extern int GetProfilingInfoCount();

	// Token: 0x06000089 RID: 137
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2739070", Offset = "0x2737670", VA = "0x182739070")]
	[PreserveSig]
	public static extern void GetProfilingInfo([Out] Oni.ProfileInfo[] info, int num);

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	public const int ConstraintTypeCount = 17;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	private const string LIBNAME = "libOni";

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public enum ConstraintType
	{
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		Tether,
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		Volume,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Chain,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		Bending,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		Distance,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		ShapeMatching,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		BendTwist,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		StretchShear,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		Pin,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		ParticleCollision,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		Density,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		Collision,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		Skin,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		Aerodynamics,
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		Stitch,
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		ParticleFriction,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		Friction
	}

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Flags]
	public enum ParticleFlags
	{
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		GroupMask = 16777215,
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		SelfCollide = 16777216,
		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		Fluid = 33554432,
		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		OneSided = 67108864
	}

	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public enum ShapeType
	{
		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		Sphere,
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		Box,
		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		Capsule,
		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		Heightmap,
		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		TriangleMesh,
		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		EdgeMesh,
		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		SignedDistanceField
	}

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public enum MaterialCombineMode
	{
		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		Average,
		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		Minimum,
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		Multiply,
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		Maximum
	}

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public enum ProfileMask : uint
	{
		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		ThreadIdMask = 4294901760U,
		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		TypeMask = 255U,
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		StackLevelMask = 65280U
	}

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public struct ProfileInfo
	{
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double start;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double end;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint info;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int pad;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;
	}

	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public struct GridCell
	{
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 center;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 size;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int count;
	}

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[Serializable]
	public struct SolverParameters
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x27392A0", Offset = "0x27378A0", VA = "0x1827392A0")]
		public SolverParameters(Oni.SolverParameters.Interpolation interpolation, Vector4 gravity)
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Tooltip("In 2D mode, particles are simulated on the XY plane only. For use in conjunction with Unity's 2D mode.")]
		public Oni.SolverParameters.Mode mode;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Tooltip("Same as Rigidbody.interpolation. Set to INTERPOLATE for cloth that is applied on a main character or closely followed by a camera. NONE for everything else.")]
		public Oni.SolverParameters.Interpolation interpolation;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Tooltip("Simulation gravity expressed in local space.")]
		public Vector3 gravity;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Percentage of velocity lost per second, between 0% (0) and 100% (1).")]
		[Range(0f, 1f)]
		public float damping;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 5f)]
		[Tooltip("Max ratio between a particle's longest and shortest axis. Use 1 for isotropic (completely round) particles.")]
		public float maxAnisotropy;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Mass-normalized kinetic energy threshold below which particle positions aren't updated.")]
		public float sleepThreshold;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Maximum distance between elements (simplices/colliders) for a contact to be generated.")]
		public float collisionMargin;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Maximum depenetration velocity applied to particles that start a frame inside an object. Low values ensure no 'explosive' collision resolution. Should be > 0 unless looking for non-physical effects.")]
		public float maxDepenetration;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Percentage of particle velocities used for continuous collision detection. Set to 0 for purely static collisions, set to 1 for pure continuous collisions.")]
		public float continuousCollisionDetection;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Percentage of shock propagation applied to particle-particle collisions. Useful for particle stacking.")]
		public float shockPropagation;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 32f)]
		[Tooltip("Amount of iterations spent on convex optimization for surface collisions.")]
		public int surfaceCollisionIterations;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Error threshold at which to stop convex optimization for surface collisions.")]
		public float surfaceCollisionTolerance;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public enum Interpolation
		{
			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			None,
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			Interpolate
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public enum Mode
		{
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			Mode3D,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			Mode2D
		}
	}

	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public struct ConstraintParameters
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2739320", Offset = "0x2737920", VA = "0x182739320")]
		public ConstraintParameters(bool enabled, Oni.ConstraintParameters.EvaluationOrder order, int iterations)
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Tooltip("Order in which constraints are evaluated. SEQUENTIAL converges faster but is not very stable. PARALLEL is very stable but converges slowly, requiring more iterations to achieve the same result.")]
		public Oni.ConstraintParameters.EvaluationOrder evaluationOrder;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Tooltip("Number of relaxation iterations performed by the constraint solver. A low number of iterations will perform better, but be less accurate.")]
		public int iterations;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Range(0.1f, 2f)]
		[Tooltip("Over (or under if < 1) relaxation factor used. At 1, no overrelaxation is performed. At 2, constraints double their relaxation rate. High values reduce stability but improve convergence.")]
		public float SORFactor;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Tooltip("Whether this constraint group is solved or not.")]
		public bool enabled;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		public enum EvaluationOrder
		{
			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4000056")]
			Sequential,
			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			Parallel
		}
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public struct Contact
	{
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 pointA;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 pointB;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 normal;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector4 tangent;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector4 bitangent;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float distance;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float normalImpulse;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float tangentImpulse;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float bitangentImpulse;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float stickImpulse;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float rollingFrictionImpulse;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int bodyA;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int bodyB;
	}
}

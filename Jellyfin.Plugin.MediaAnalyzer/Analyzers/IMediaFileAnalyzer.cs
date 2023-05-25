namespace Jellyfin.Plugin.MediaAnalyzer;

using System.Collections.ObjectModel;
using System.Threading;

/// <summary>
/// Media file analyzer interface.
/// </summary>
public interface IMediaFileAnalyzer
{
    /// <summary>
    /// Analyze media files for shared introductions or credits, returning all media files that were **not successfully analyzed**.
    /// </summary>
    /// <param name="analysisQueue">Collection of unanalyzed media files.</param>
    /// <param name="mode">Analysis mode.</param>
    /// <param name="cancellationToken">Cancellation token from scheduled task.</param>
    /// <returns>Collection of media files that were **unsuccessfully analyzed**.</returns>
    public ReadOnlyCollection<QueuedMedia> AnalyzeMediaFiles(
        ReadOnlyCollection<QueuedMedia> analysisQueue,
        AnalysisMode mode,
        CancellationToken cancellationToken);
}

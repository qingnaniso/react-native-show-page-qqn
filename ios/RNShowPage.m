
#import "RNShowPage.h"

@implementation RNShowPage

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE(show)
{
    NSLog(@"hello");
}

@end

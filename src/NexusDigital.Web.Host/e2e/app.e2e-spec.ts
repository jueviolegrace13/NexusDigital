import { NexusDigitalTemplatePage } from './app.po';

describe('NexusDigital App', function() {
  let page: NexusDigitalTemplatePage;

  beforeEach(() => {
    page = new NexusDigitalTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
